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

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {
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

                ListViewItem item = new ListViewItem(newParcel.Id.ToString());
                item.SubItems.Add(newParcel.Description);
                item.SubItems.Add(newParcel.Weight.ToString());
                item.SubItems.Add(newParcel.Cost.ToString());
                item.SubItems.Add(newParcel.ShipmentDate?.ToString("dd/MM/yyyy"));

                materialListView1.Items.Add(item);

                descriptionTextBox.Clear();
                weightTextBox.Clear();
                costTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void materialTextBox21_Click_1(object sender, EventArgs e)
        {
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!DataManager.Entities.Any()) return;

                materialListView1.Items.Clear();
                IEnumerable<IEntity> foundEntities;
                string searchText = searchTextBox.Text;

                if (string.IsNullOrEmpty(searchText))
                {
                    foundEntities = DataManager.Entities;
                }
                else
                {
                    foundEntities = DataManager.Filter(entity => entity.Search(searchText));
                }

                foreach (IEntity entity in foundEntities)
                {
                    var parcelEntity = entity as Parcel;
                    if (parcelEntity != null)
                    {
                        ListViewItem item = new ListViewItem(parcelEntity.Id.ToString());
                        item.SubItems.Add(parcelEntity.Description);
                        item.SubItems.Add(parcelEntity.Weight.ToString());
                        item.SubItems.Add(parcelEntity.Cost.ToString());
                        item.SubItems.Add(parcelEntity.ShipmentDate?.ToString("dd/MM/yyyy") ?? string.Empty);

                        materialListView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}