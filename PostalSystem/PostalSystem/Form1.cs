using System;
using System.Collections.Generic;
using System.Linq; 
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

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
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                string idStr = materialListView1.SelectedItems[0].Text; 
                if (Guid.TryParse(idStr, out Guid id))
                {
                    var detailText = DataManager.Entities
                        .OfType<Parcel>()
                        .Where(p => p.Id == id)
                        .Select(p => $"Description: {p.Description} | Weight: {p.Weight} kg")
                        .FirstOrDefault();

                    if (detailText != null)
                    {
                        selectedItemTextBox.Text = detailText; 
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

                FileManager.Add(newParcel);
                DataManager.Add(newParcel);

                searchButton_Click_1(sender, e);
                CalculateStatistics();

                descriptionTextBox.Clear();
                weightTextBox.Clear();
                costTextBox.Clear();
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
                if (!DataManager.Entities.Any()) return;

                materialListView1.Items.Clear();

                var parcels = DataManager.Entities.OfType<Parcel>();

                string searchText = searchTextBox.Text;
                if (!string.IsNullOrEmpty(searchText))
                {
                    parcels = parcels.Where(p => p.Search(searchText));
                }

                if (double.TryParse(weightFromTextBox.Text, out double weightFrom) &&
                    double.TryParse(weightToTextBox.Text, out double weightTo))
                {
                    parcels = parcels.Where(p => p.Weight >= weightFrom && p.Weight <= weightTo);
                }

               
                var orderedParcels = parcels
                    .OrderBy(p => p.Description)
                    .ThenByDescending(p => p.ShipmentDate);

                var paginatedParcels = orderedParcels
                    .Skip(currentPage * PAGE_LIMIT)
                    .Take(PAGE_LIMIT)
                    .ToList();

                foreach (var parcelEntity in paginatedParcels)
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
            int totalRecords = DataManager.Entities.OfType<Parcel>().Count();
            if ((currentPage + 1) * PAGE_LIMIT < totalRecords)
            {
                currentPage++;
                searchButton_Click_1(sender, e);
            }
        }

        
        private void CalculateStatistics()
        {
            var parcels = DataManager.Entities.OfType<Parcel>().ToList();

            
            int totalParcelsCount = parcels.Count();
            countTextBox.Text = totalParcelsCount.ToString();

            if (parcels.Any())
            {
                double maxWeight = parcels.Max(p => p.Weight);
                maxWeightTextBox.Text = $"{maxWeight} kg";
            }
            else
            {
                maxWeightTextBox.Text = "0 kg";
            }
        }

        
        private void loadSourceBtn_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog { Filter = "Text Files (*.txt)|*.txt" })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<Parcel> anotherParcels = FileManager.GetEntities<Parcel>(fileDialog.FileName);

                    var currentIds = DataManager.Entities.Select(p => p.Id).ToList();

                    var uniqueNewParcels = anotherParcels.ExceptBy(currentIds, p => p.Id);

                    var allParcels = DataManager.Entities.OfType<Parcel>()
                        .Concat(uniqueNewParcels)
                        .ToList();

                    DataManager.Entities.Clear();
                    foreach (var p in allParcels)
                    {
                        DataManager.Add(p);
                    }

                    currentPage = 0;
                    searchButton_Click_1(sender, e);
                    CalculateStatistics();

                    MessageBox.Show("Data successfully merged using LINQ set operations!");
                }
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