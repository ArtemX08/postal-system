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
            Description = new ColumnHeader();
            Weight = new ColumnHeader();
            Cost = new ColumnHeader();
            Shipment_Date = new ColumnHeader();
            weightTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            costTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            shipmentDatePicker = new DateTimePicker();
            addBtn = new MaterialSkin.Controls.MaterialButton();
            searchTextBox = new TextBox();
            searchButton = new Button();
            descriptionTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { ID, Description, Weight, Cost, Shipment_Date });
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(9, 112);
            materialListView1.Margin = new Padding(4, 5, 4, 5);
            materialListView1.MinimumSize = new Size(286, 167);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(1126, 237);
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
            // Description
            // 
            Description.DisplayIndex = 4;
            Description.Text = "Description";
            Description.Width = 120;
            // 
            // Weight
            // 
            Weight.DisplayIndex = 1;
            Weight.Text = "Weight";
            Weight.Width = 100;
            // 
            // Cost
            // 
            Cost.DisplayIndex = 2;
            Cost.Text = "Cost";
            Cost.Width = 100;
            // 
            // Shipment_Date
            // 
            Shipment_Date.DisplayIndex = 3;
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
            weightTextBox.Location = new Point(9, 395);
            weightTextBox.Margin = new Padding(4, 5, 4, 5);
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
            weightTextBox.Size = new Size(357, 48);
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
            costTextBox.Location = new Point(9, 485);
            costTextBox.Margin = new Padding(4, 5, 4, 5);
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
            costTextBox.Size = new Size(357, 48);
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
            shipmentDatePicker.Location = new Point(436, 395);
            shipmentDatePicker.Margin = new Padding(4, 5, 4, 5);
            shipmentDatePicker.Name = "shipmentDatePicker";
            shipmentDatePicker.Size = new Size(284, 39);
            shipmentDatePicker.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(516, 578);
            addBtn.Margin = new Padding(6, 10, 6, 10);
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
            // searchTextBox
            // 
            searchTextBox.Location = new Point(834, 395);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(284, 31);
            searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(923, 453);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 6;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click_1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.AnimateReadOnly = false;
            descriptionTextBox.BackgroundImageLayout = ImageLayout.None;
            descriptionTextBox.CharacterCasing = CharacterCasing.Normal;
            descriptionTextBox.Depth = 0;
            descriptionTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            descriptionTextBox.HideSelection = true;
            descriptionTextBox.Hint = "Enter Description";
            descriptionTextBox.LeadingIcon = null;
            descriptionTextBox.Location = new Point(7, 566);
            descriptionTextBox.MaxLength = 32767;
            descriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PasswordChar = '\0';
            descriptionTextBox.PrefixSuffixText = null;
            descriptionTextBox.ReadOnly = false;
            descriptionTextBox.RightToLeft = RightToLeft.No;
            descriptionTextBox.SelectedText = "";
            descriptionTextBox.SelectionLength = 0;
            descriptionTextBox.SelectionStart = 0;
            descriptionTextBox.ShortcutsEnabled = true;
            descriptionTextBox.Size = new Size(359, 48);
            descriptionTextBox.TabIndex = 7;
            descriptionTextBox.TabStop = false;
            descriptionTextBox.TextAlign = HorizontalAlignment.Left;
            descriptionTextBox.TrailingIcon = null;
            descriptionTextBox.UseSystemPasswordChar = false;
            descriptionTextBox.Click += materialTextBox21_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 667);
            Controls.Add(descriptionTextBox);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(addBtn);
            Controls.Add(shipmentDatePicker);
            Controls.Add(costTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(materialListView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Padding = new Padding(4, 107, 4, 5);
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
        private TextBox searchTextBox;
        private ColumnHeader Description;
        private Button searchButton;
        private MaterialSkin.Controls.MaterialTextBox2 descriptionTextBox;
    }
}
