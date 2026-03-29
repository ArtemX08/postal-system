using System;
using System.Collections.Generic;
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
                double weight = double.Parse(weightTextBox.Text); 
                decimal cost = decimal.Parse(costTextBox.Text); 
                DateTime date = shipmentDatePicker.Value;

                Parcel newParcel = new Parcel(Guid.NewGuid(), weight, cost, date, null);

                FileManager.Add(newParcel);

                ListViewItem item = new ListViewItem(newParcel.Id.ToString());
                item.SubItems.Add(newParcel.Weight.ToString());
                item.SubItems.Add(newParcel.Cost.ToString());
                item.SubItems.Add(newParcel.ShipmentDate?.ToString("dd/MM/yyyy"));

                materialListView1.Items.Add(item);

                weightTextBox.Clear();
                costTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }


    }
}