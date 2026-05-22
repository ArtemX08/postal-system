using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace PostalSystem
{
    public partial class Form1 : MaterialForm
    {
        private const int PAGE_LIMIT = 5;
        private int currentPage = 0;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalculateStatistics();
            searchButton_Click_1(sender, e);
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                string idStr = materialListView1.SelectedItems[0].Text;
                if (Guid.TryParse(idStr, out Guid id))
                {
                    using (var db = new ApplicationContext())
                    {
                        var parcel = db.Parcels.FirstOrDefault(p => p.Id == id);
                        if (parcel != null)
                        {
                            selectedItemTextBox.Text = $"Description: {parcel.Description} | Weight: {parcel.Weight} kg";

                            descriptionTextBox.Text = parcel.Description;
                            weightTextBox.Text = parcel.Weight.ToString();
                            costTextBox.Text = parcel.Cost.ToString();
                            if (parcel.ShipmentDate.HasValue)
                            {
                                shipmentDatePicker.Value = parcel.ShipmentDate.Value;
                            }
                        }
                    }
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string description = descriptionTextBox.Text;
                double weight = double.Parse(weightTextBox.Text);
                decimal cost = decimal.Parse(costTextBox.Text);
                DateTime date = shipmentDatePicker.Value;

                Parcel newParcel = new Parcel(Guid.NewGuid(), description, weight, cost, date, null);

                using (var db = new ApplicationContext())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            db.Parcels.Add(newParcel);
                            db.SaveChanges();
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                descriptionTextBox.Clear();
                weightTextBox.Clear();
                costTextBox.Clear();

                searchButton_Click_1(sender, e);
                CalculateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                materialListView1.Items.Clear();

                using (var db = new ApplicationContext())
                {
                    var query = db.Parcels
                        .AsNoTracking()
                        .TagWith("App Query: Searching and filtering parcels")
                        .AsQueryable();

                    string searchText = searchTextBox.Text;
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query = query.Where(p => p.Description.Contains(searchText));
                    }

                    if (double.TryParse(weightFromTextBox.Text, out double weightFrom) &&
                        double.TryParse(weightToTextBox.Text, out double weightTo))
                    {
                        query = query.Where(p => p.Weight >= weightFrom && p.Weight <= weightTo);
                    }

                    var orderedParcels = query
                        .OrderBy(p => p.Description)
                        .ThenByDescending(p => p.ShipmentDate)
                        .Skip(currentPage * PAGE_LIMIT)
                        .Take(PAGE_LIMIT)
                        .ToList();

                    foreach (var parcelEntity in orderedParcels)
                    {
                        ListViewItem item = new ListViewItem(parcelEntity.Id.ToString());
                        item.SubItems.Add(parcelEntity.Description);
                        item.SubItems.Add(parcelEntity.Weight.ToString());
                        item.SubItems.Add(parcelEntity.Cost.ToString());
                        item.SubItems.Add(parcelEntity.ShipmentDate?.ToString("dd/MM/yyyy") ?? string.Empty);

                        materialListView1.Items.Add(item);
                    }

                    pageNumTextBox.Text = (currentPage + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void prevBtn_Click_1(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                searchButton_Click_1(sender, e);
            }
        }

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                int totalRecords = db.Parcels.Count();
                if ((currentPage + 1) * PAGE_LIMIT < totalRecords)
                {
                    currentPage++;
                    searchButton_Click_1(sender, e);
                }
            }
        }

        private void CalculateStatistics()
        {
            using (var db = new ApplicationContext())
            {
                int totalParcelsCount = db.Parcels.Count();
                countTextBox.Text = totalParcelsCount.ToString();

                if (totalParcelsCount > 0)
                {
                    double maxWeight = db.Parcels.Max(p => p.Weight);
                    maxWeightTextBox.Text = $"{maxWeight} kg";
                }
                else
                {
                    maxWeightTextBox.Text = "0 kg";
                }
            }
        }

        private void loadSourceBtn_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog { Filter = "Text Files (*.txt)|*.txt" })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        List<Parcel> anotherParcels = FileManager.GetEntities<Parcel>(fileDialog.FileName);

                        using (var db = new ApplicationContext())
                        {
                            var currentIds = db.Parcels.Select(p => p.Id).ToList();
                            var uniqueNewParcels = anotherParcels.Where(p => !currentIds.Contains(p.Id)).ToList();

                            if (uniqueNewParcels.Any())
                            {
                                db.Parcels.AddRange(uniqueNewParcels);
                                db.SaveChanges();
                            }
                        }

                        currentPage = 0;
                        searchButton_Click_1(sender, e);
                        CalculateStatistics();

                        MessageBox.Show("Data successfully imported to database!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error importing data: " + ex.Message);
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialListView1.SelectedItems.Count > 0)
                {
                    if (Guid.TryParse(materialListView1.SelectedItems[0].Text, out Guid id))
                    {
                        string desc = descriptionTextBox.Text;
                        double weight = double.Parse(weightTextBox.Text);
                        decimal cost = decimal.Parse(costTextBox.Text);
                        DateTime date = shipmentDatePicker.Value;

                        using (var db = new ApplicationContext())
                        {
                            db.Database.ExecuteSqlInterpolated($"UPDATE Parcels SET Description = {desc}, Weight = {weight}, Cost = {cost}, ShipmentDate = {date} WHERE Id = {id}");
                        }

                        descriptionTextBox.Clear();
                        weightTextBox.Clear();
                        costTextBox.Clear();

                        searchButton_Click_1(sender, e);
                        CalculateStatistics();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialListView1.SelectedItems.Count > 0)
                {
                    if (Guid.TryParse(materialListView1.SelectedItems[0].Text, out Guid id))
                    {
                        using (var db = new ApplicationContext())
                        {
                            db.Database.ExecuteSqlInterpolated($"DELETE FROM Parcels WHERE Id = {id}");
                        }

                        selectedItemTextBox.Text = string.Empty;
                        descriptionTextBox.Clear();
                        weightTextBox.Clear();
                        costTextBox.Clear();

                        searchButton_Click_1(sender, e);
                        CalculateStatistics();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void weightToTextBox_Click(object sender, EventArgs e) { }
        private void weightFromTextBox_Click(object sender, EventArgs e) { }
        private void pageNumTextBox_Click(object sender, EventArgs e) { }
        private void countTextBox_Click(object sender, EventArgs e) { }
        private void maxWeightTextBox_Click(object sender, EventArgs e) { }
        private void selectedItemTextBox_Click(object sender, EventArgs e) { }
        private void materialTextBox21_Click(object sender, EventArgs e) { }
        private void materialTextBox21_Click_1(object sender, EventArgs e) { }
    }
}