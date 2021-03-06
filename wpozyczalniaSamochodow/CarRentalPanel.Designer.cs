﻿namespace wypozyczalniaSamochodow
{
    partial class CarRentalPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.carTable = new System.Windows.Forms.DataGridView();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 579);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(50, 120);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 25);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Powrót";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.goBack);
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.CustomFormat = "yyyy-MM-dd";
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromPicker.Location = new System.Drawing.Point(230, 65);
            this.dateFromPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(151, 20);
            this.dateFromPicker.TabIndex = 1;
            this.dateFromPicker.ValueChanged += new System.EventHandler(this.setDateBegin);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Do:";
            // 
            // dateToPicker
            // 
            this.dateToPicker.CustomFormat = "yyyy-MM-dd";
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToPicker.Location = new System.Drawing.Point(455, 65);
            this.dateToPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(150, 20);
            this.dateToPicker.TabIndex = 4;
            this.dateToPicker.ValueChanged += new System.EventHandler(this.setDateEnd);
            // 
            // typeCombobox
            // 
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Location = new System.Drawing.Point(270, 110);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(121, 21);
            this.typeCombobox.TabIndex = 33;
            this.typeCombobox.SelectedIndexChanged += new System.EventHandler(this.setCarType);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Typ samochodu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(490, 110);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 25);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.getAvaliableCars);
            // 
            // carTable
            // 
            this.carTable.AllowUserToAddRows = false;
            this.carTable.AllowUserToDeleteRows = false;
            this.carTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brand,
            this.model,
            this.rentButton});
            this.carTable.Location = new System.Drawing.Point(153, 176);
            this.carTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carTable.Name = "carTable";
            this.carTable.ReadOnly = true;
            this.carTable.RowHeadersWidth = 51;
            this.carTable.RowTemplate.Height = 24;
            this.carTable.Size = new System.Drawing.Size(935, 404);
            this.carTable.TabIndex = 36;
            this.carTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carTable_CellContentClick);
            // 
            // brand
            // 
            this.brand.HeaderText = "Marka:";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 125;
            // 
            // model
            // 
            this.model.HeaderText = "Model:";
            this.model.MinimumWidth = 6;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Width = 125;
            // 
            // rentButton
            // 
            this.rentButton.HeaderText = "Wypożycz:";
            this.rentButton.MinimumWidth = 6;
            this.rentButton.Name = "rentButton";
            this.rentButton.ReadOnly = true;
            this.rentButton.Text = "Wypożycz";
            this.rentButton.Width = 125;
            // 
            // CarRentalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.carTable);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeCombobox);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CarRentalPanel";
            this.Size = new System.Drawing.Size(1090, 579);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.ComboBox typeCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView carTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewButtonColumn rentButton;
    }
}
