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
            weightFromTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            weightToTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            prevBtn = new MaterialSkin.Controls.MaterialButton();
            nextBtn = new MaterialSkin.Controls.MaterialButton();
            pageNumTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            countTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            maxWeightTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            selectedItemTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            loadSourceBtn = new MaterialSkin.Controls.MaterialButton();
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
            shipmentDatePicker.Location = new Point(6, 393);
            shipmentDatePicker.Name = "shipmentDatePicker";
            shipmentDatePicker.Size = new Size(250, 29);
            shipmentDatePicker.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addBtn.Depth = 0;
            addBtn.HighEmphasis = true;
            addBtn.Icon = null;
            addBtn.Location = new Point(319, 502);
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
            // searchTextBox
            // 
            searchTextBox.Location = new Point(513, 355);
            searchTextBox.Margin = new Padding(2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(200, 23);
            searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(717, 358);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(78, 20);
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
            descriptionTextBox.Location = new Point(5, 340);
            descriptionTextBox.Margin = new Padding(2);
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
            descriptionTextBox.Size = new Size(251, 48);
            descriptionTextBox.TabIndex = 7;
            descriptionTextBox.TabStop = false;
            descriptionTextBox.TextAlign = HorizontalAlignment.Left;
            descriptionTextBox.TrailingIcon = null;
            descriptionTextBox.UseSystemPasswordChar = false;
            descriptionTextBox.Click += materialTextBox21_Click_1;
            // 
            // weightFromTextBox
            // 
            weightFromTextBox.AnimateReadOnly = false;
            weightFromTextBox.BackgroundImageLayout = ImageLayout.None;
            weightFromTextBox.CharacterCasing = CharacterCasing.Normal;
            weightFromTextBox.Depth = 0;
            weightFromTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            weightFromTextBox.HideSelection = true;
            weightFromTextBox.Hint = "Weight From:";
            weightFromTextBox.LeadingIcon = null;
            weightFromTextBox.Location = new Point(513, 383);
            weightFromTextBox.MaxLength = 32767;
            weightFromTextBox.MouseState = MaterialSkin.MouseState.OUT;
            weightFromTextBox.Name = "weightFromTextBox";
            weightFromTextBox.PasswordChar = '\0';
            weightFromTextBox.PrefixSuffixText = null;
            weightFromTextBox.ReadOnly = false;
            weightFromTextBox.RightToLeft = RightToLeft.No;
            weightFromTextBox.SelectedText = "";
            weightFromTextBox.SelectionLength = 0;
            weightFromTextBox.SelectionStart = 0;
            weightFromTextBox.ShortcutsEnabled = true;
            weightFromTextBox.Size = new Size(280, 48);
            weightFromTextBox.TabIndex = 8;
            weightFromTextBox.TabStop = false;
            weightFromTextBox.TextAlign = HorizontalAlignment.Left;
            weightFromTextBox.TrailingIcon = null;
            weightFromTextBox.UseSystemPasswordChar = false;
            weightFromTextBox.Click += weightFromTextBox_Click;
            // 
            // weightToTextBox
            // 
            weightToTextBox.AnimateReadOnly = false;
            weightToTextBox.BackgroundImageLayout = ImageLayout.None;
            weightToTextBox.CharacterCasing = CharacterCasing.Normal;
            weightToTextBox.Depth = 0;
            weightToTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            weightToTextBox.HideSelection = true;
            weightToTextBox.Hint = "Weight To:";
            weightToTextBox.LeadingIcon = null;
            weightToTextBox.Location = new Point(513, 436);
            weightToTextBox.MaxLength = 32767;
            weightToTextBox.MouseState = MaterialSkin.MouseState.OUT;
            weightToTextBox.Name = "weightToTextBox";
            weightToTextBox.PasswordChar = '\0';
            weightToTextBox.PrefixSuffixText = null;
            weightToTextBox.ReadOnly = false;
            weightToTextBox.RightToLeft = RightToLeft.No;
            weightToTextBox.SelectedText = "";
            weightToTextBox.SelectionLength = 0;
            weightToTextBox.SelectionStart = 0;
            weightToTextBox.ShortcutsEnabled = true;
            weightToTextBox.Size = new Size(280, 48);
            weightToTextBox.TabIndex = 9;
            weightToTextBox.TabStop = false;
            weightToTextBox.TextAlign = HorizontalAlignment.Left;
            weightToTextBox.TrailingIcon = null;
            weightToTextBox.UseSystemPasswordChar = false;
            weightToTextBox.Click += weightToTextBox_Click;
            // 
            // prevBtn
            // 
            prevBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            prevBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            prevBtn.Depth = 0;
            prevBtn.HighEmphasis = true;
            prevBtn.Icon = null;
            prevBtn.Location = new Point(544, 502);
            prevBtn.Margin = new Padding(4, 6, 4, 6);
            prevBtn.MouseState = MaterialSkin.MouseState.HOVER;
            prevBtn.Name = "prevBtn";
            prevBtn.NoAccentTextColor = Color.Empty;
            prevBtn.Size = new Size(64, 36);
            prevBtn.TabIndex = 10;
            prevBtn.Text = "PREV";
            prevBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            prevBtn.UseAccentColor = false;
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click_1;
            // 
            // nextBtn
            // 
            nextBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextBtn.Depth = 0;
            nextBtn.HighEmphasis = true;
            nextBtn.Icon = null;
            nextBtn.Location = new Point(669, 502);
            nextBtn.Margin = new Padding(4, 6, 4, 6);
            nextBtn.MouseState = MaterialSkin.MouseState.HOVER;
            nextBtn.Name = "nextBtn";
            nextBtn.NoAccentTextColor = Color.Empty;
            nextBtn.Size = new Size(64, 36);
            nextBtn.TabIndex = 11;
            nextBtn.Text = "NEXT";
            nextBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nextBtn.UseAccentColor = false;
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click_1;
            // 
            // pageNumTextBox
            // 
            pageNumTextBox.AnimateReadOnly = false;
            pageNumTextBox.BackgroundImageLayout = ImageLayout.None;
            pageNumTextBox.CharacterCasing = CharacterCasing.Normal;
            pageNumTextBox.Depth = 0;
            pageNumTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pageNumTextBox.HideSelection = true;
            pageNumTextBox.LeadingIcon = null;
            pageNumTextBox.Location = new Point(615, 490);
            pageNumTextBox.MaxLength = 32767;
            pageNumTextBox.MouseState = MaterialSkin.MouseState.OUT;
            pageNumTextBox.Name = "pageNumTextBox";
            pageNumTextBox.PasswordChar = '\0';
            pageNumTextBox.PrefixSuffixText = null;
            pageNumTextBox.ReadOnly = true;
            pageNumTextBox.RightToLeft = RightToLeft.No;
            pageNumTextBox.SelectedText = "";
            pageNumTextBox.SelectionLength = 0;
            pageNumTextBox.SelectionStart = 0;
            pageNumTextBox.ShortcutsEnabled = true;
            pageNumTextBox.Size = new Size(47, 48);
            pageNumTextBox.TabIndex = 12;
            pageNumTextBox.TabStop = false;
            pageNumTextBox.TextAlign = HorizontalAlignment.Left;
            pageNumTextBox.TrailingIcon = null;
            pageNumTextBox.UseSystemPasswordChar = false;
            pageNumTextBox.Click += pageNumTextBox_Click;
            // 
            // countTextBox
            // 
            countTextBox.AnimateReadOnly = false;
            countTextBox.BackgroundImageLayout = ImageLayout.None;
            countTextBox.CharacterCasing = CharacterCasing.Normal;
            countTextBox.Depth = 0;
            countTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            countTextBox.HideSelection = true;
            countTextBox.Hint = "Future Parcels Count:";
            countTextBox.LeadingIcon = null;
            countTextBox.Location = new Point(262, 291);
            countTextBox.MaxLength = 32767;
            countTextBox.MouseState = MaterialSkin.MouseState.OUT;
            countTextBox.Name = "countTextBox";
            countTextBox.PasswordChar = '\0';
            countTextBox.PrefixSuffixText = null;
            countTextBox.ReadOnly = true;
            countTextBox.RightToLeft = RightToLeft.No;
            countTextBox.SelectedText = "";
            countTextBox.SelectionLength = 0;
            countTextBox.SelectionStart = 0;
            countTextBox.ShortcutsEnabled = true;
            countTextBox.Size = new Size(250, 48);
            countTextBox.TabIndex = 13;
            countTextBox.TabStop = false;
            countTextBox.TextAlign = HorizontalAlignment.Left;
            countTextBox.TrailingIcon = null;
            countTextBox.UseSystemPasswordChar = false;
            countTextBox.Click += countTextBox_Click;
            // 
            // maxWeightTextBox
            // 
            maxWeightTextBox.AnimateReadOnly = false;
            maxWeightTextBox.BackgroundImageLayout = ImageLayout.None;
            maxWeightTextBox.CharacterCasing = CharacterCasing.Normal;
            maxWeightTextBox.Depth = 0;
            maxWeightTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maxWeightTextBox.HideSelection = true;
            maxWeightTextBox.Hint = "Max Weight:";
            maxWeightTextBox.LeadingIcon = null;
            maxWeightTextBox.Location = new Point(530, 291);
            maxWeightTextBox.MaxLength = 32767;
            maxWeightTextBox.MouseState = MaterialSkin.MouseState.OUT;
            maxWeightTextBox.Name = "maxWeightTextBox";
            maxWeightTextBox.PasswordChar = '\0';
            maxWeightTextBox.PrefixSuffixText = null;
            maxWeightTextBox.ReadOnly = true;
            maxWeightTextBox.RightToLeft = RightToLeft.No;
            maxWeightTextBox.SelectedText = "";
            maxWeightTextBox.SelectionLength = 0;
            maxWeightTextBox.SelectionStart = 0;
            maxWeightTextBox.ShortcutsEnabled = true;
            maxWeightTextBox.Size = new Size(250, 48);
            maxWeightTextBox.TabIndex = 14;
            maxWeightTextBox.TabStop = false;
            maxWeightTextBox.TextAlign = HorizontalAlignment.Left;
            maxWeightTextBox.TrailingIcon = null;
            maxWeightTextBox.UseSystemPasswordChar = false;
            maxWeightTextBox.Click += maxWeightTextBox_Click;
            // 
            // selectedItemTextBox
            // 
            selectedItemTextBox.AnimateReadOnly = false;
            selectedItemTextBox.BackgroundImageLayout = ImageLayout.None;
            selectedItemTextBox.CharacterCasing = CharacterCasing.Normal;
            selectedItemTextBox.Depth = 0;
            selectedItemTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            selectedItemTextBox.HideSelection = true;
            selectedItemTextBox.LeadingIcon = null;
            selectedItemTextBox.Location = new Point(261, 237);
            selectedItemTextBox.MaxLength = 32767;
            selectedItemTextBox.MouseState = MaterialSkin.MouseState.OUT;
            selectedItemTextBox.Name = "selectedItemTextBox";
            selectedItemTextBox.PasswordChar = '\0';
            selectedItemTextBox.PrefixSuffixText = null;
            selectedItemTextBox.ReadOnly = true;
            selectedItemTextBox.RightToLeft = RightToLeft.No;
            selectedItemTextBox.SelectedText = "";
            selectedItemTextBox.SelectionLength = 0;
            selectedItemTextBox.SelectionStart = 0;
            selectedItemTextBox.ShortcutsEnabled = true;
            selectedItemTextBox.Size = new Size(532, 48);
            selectedItemTextBox.TabIndex = 15;
            selectedItemTextBox.TabStop = false;
            selectedItemTextBox.TextAlign = HorizontalAlignment.Left;
            selectedItemTextBox.TrailingIcon = null;
            selectedItemTextBox.UseSystemPasswordChar = false;
            selectedItemTextBox.Click += selectedItemTextBox_Click;
            // 
            // loadSourceBtn
            // 
            loadSourceBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadSourceBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loadSourceBtn.Depth = 0;
            loadSourceBtn.HighEmphasis = true;
            loadSourceBtn.Icon = null;
            loadSourceBtn.Location = new Point(16, 502);
            loadSourceBtn.Margin = new Padding(4, 6, 4, 6);
            loadSourceBtn.MouseState = MaterialSkin.MouseState.HOVER;
            loadSourceBtn.Name = "loadSourceBtn";
            loadSourceBtn.NoAccentTextColor = Color.Empty;
            loadSourceBtn.Size = new Size(190, 36);
            loadSourceBtn.TabIndex = 16;
            loadSourceBtn.Text = "LOAD ANOTHER SOURCE";
            loadSourceBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loadSourceBtn.UseAccentColor = false;
            loadSourceBtn.UseVisualStyleBackColor = true;
            loadSourceBtn.Click += loadSourceBtn_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(loadSourceBtn);
            Controls.Add(selectedItemTextBox);
            Controls.Add(maxWeightTextBox);
            Controls.Add(countTextBox);
            Controls.Add(pageNumTextBox);
            Controls.Add(nextBtn);
            Controls.Add(prevBtn);
            Controls.Add(weightToTextBox);
            Controls.Add(weightFromTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(addBtn);
            Controls.Add(shipmentDatePicker);
            Controls.Add(costTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(materialListView1);
            Name = "Form1";
            Text = "Postal System";
            Load += Form1_Load;
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
        private MaterialSkin.Controls.MaterialTextBox2 weightFromTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 weightToTextBox;
        private MaterialSkin.Controls.MaterialButton prevBtn;
        private MaterialSkin.Controls.MaterialButton nextBtn;
        private MaterialSkin.Controls.MaterialTextBox2 pageNumTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 countTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 maxWeightTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 selectedItemTextBox;
        private MaterialSkin.Controls.MaterialButton loadSourceBtn;
    }
}
