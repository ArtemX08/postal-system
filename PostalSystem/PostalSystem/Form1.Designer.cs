namespace PostalSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            ID = new ColumnHeader();
            Weight = new ColumnHeader();
            Cost = new ColumnHeader();
            Shipment_Date = new ColumnHeader();
            weightTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            costTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            shipmentDatePicker = new DateTimePicker();
            addBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { ID, Weight, Cost, Shipment_Date });
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(6, 67);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(788, 142);
            materialListView1.TabIndex = 0;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            materialListView1.SelectedIndexChanged += materialListView1_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 300;
            // 
            // Weight
            // 
            Weight.Text = "Weight";
            Weight.Width = 100;
            // 
            // Cost
            // 
            Cost.Text = "Cost";
            Cost.Width = 100;
            // 
            // Shipment_Date
            // 
            Shipment_Date.Text = "Shipment Date";
            Shipment_Date.Width = 150;
            // 
            // weightTextBox
            // 
            weightTextBox.AnimateReadOnly = false;
            weightTextBox.BackgroundImageLayout = ImageLayout.None;
            weightTextBox.CharacterCasing = CharacterCasing.Normal;
            weightTextBox.Depth = 0;
            weightTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            weightTextBox.HideSelection = true;
            weightTextBox.Hint = "Enter weight (kg)";
            weightTextBox.LeadingIcon = null;
            weightTextBox.Location = new Point(6, 237);
            weightTextBox.MaxLength = 32767;
            weightTextBox.MouseState = MaterialSkin.MouseState.OUT;
            weightTextBox.Name = "weightTextBox";
            weightTextBox.PasswordChar = '\0';
            weightTextBox.PrefixSuffixText = null;
            weightTextBox.ReadOnly = false;
            weightTextBox.RightToLeft = RightToLeft.No;
            weightTextBox.SelectedText = "";
            weightTextBox.SelectionLength = 0;
            weightTextBox.SelectionStart = 0;
            weightTextBox.ShortcutsEnabled = true;
            weightTextBox.Size = new Size(250, 48);
            weightTextBox.TabIndex = 1;
            weightTextBox.TabStop = false;
            weightTextBox.TextAlign = HorizontalAlignment.Left;
            weightTextBox.TrailingIcon = null;
            weightTextBox.UseSystemPasswordChar = false;
            weightTextBox.Click += materialTextBox21_Click;
            // 
            // costTextBox
            // 
            costTextBox.AnimateReadOnly = false;
            costTextBox.BackgroundImageLayout = ImageLayout.None;
            costTextBox.CharacterCasing = CharacterCasing.Normal;
            costTextBox.Depth = 0;
            costTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            costTextBox.HideSelection = true;
            costTextBox.Hint = "Enter cost (UAH)";
            costTextBox.LeadingIcon = null;
            costTextBox.Location = new Point(6, 291);
            costTextBox.MaxLength = 32767;
            costTextBox.MouseState = MaterialSkin.MouseState.OUT;
            costTextBox.Name = "costTextBox";
            costTextBox.PasswordChar = '\0';
            costTextBox.PrefixSuffixText = null;
            costTextBox.ReadOnly = false;
            costTextBox.RightToLeft = RightToLeft.No;
            costTextBox.SelectedText = "";
            costTextBox.SelectionLength = 0;
            costTextBox.SelectionStart = 0;
            costTextBox.ShortcutsEnabled = true;
            costTextBox.Size = new Size(250, 48);
            costTextBox.TabIndex = 2;
            costTextBox.TabStop = false;
            costTextBox.TextAlign = HorizontalAlignment.Left;
            costTextBox.TrailingIcon = null;
            costTextBox.UseSystemPasswordChar = false;
            // 
            // shipmentDatePicker
            // 
            shipmentDatePicker.CustomFormat = "dd/MM/yyyy";
            shipmentDatePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            shipmentDatePicker.Format = DateTimePickerFormat.Custom;
            shipmentDatePicker.Location = new Point(594, 237);
            shipmentDatePicker.Name = "shipmentDatePicker";
            shipmentDatePicker.Size = new Size(200, 29);
            shipmentDatePicker.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(377, 355);
            addBtn.Margin = new Padding(4, 6, 4, 6);
            addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn.Name = "addBtn";
            addBtn.NoAccentTextColor = Color.Empty;
            addBtn.Size = new Size(108, 36);
            addBtn.TabIndex = 4;
            addBtn.Text = "ADD PARCEL";
            addBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addBtn.UseAccentColor = false;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(addBtn);
            Controls.Add(shipmentDatePicker);
            Controls.Add(costTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(materialListView1);
            Name = "Form1";
            Text = "Postal System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader ID;
        private ColumnHeader Weight;
        private ColumnHeader Cost;
        private ColumnHeader Shipment_Date;
        private MaterialSkin.Controls.MaterialTextBox2 weightTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 costTextBox;
        private DateTimePicker shipmentDatePicker;
        private MaterialSkin.Controls.MaterialButton addBtn;
    }
}
