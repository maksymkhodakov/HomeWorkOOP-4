
namespace WinFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.byttonAddGoods = new System.Windows.Forms.Button();
            this.buttonDeleteGoods = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxOriginCountry = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDateOfPacking = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPagesAmount = new System.Windows.Forms.TextBox();
            this.textBoxAuthors = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxDimension = new System.Windows.Forms.TextBox();
            this.textBoxExpirationDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAmountInStorage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginCountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPackingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagesAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DimensionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountInStorageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceColumn,
            this.OriginCountryColumn,
            this.NameColumn,
            this.DateOfPackingColumn,
            this.DescriptionColumn,
            this.PagesAmountColumn,
            this.PublisherColumn,
            this.AuthorsColumn,
            this.ExpirationDateColumn,
            this.DimensionColumn,
            this.AmountInStorageColumn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 173);
            this.dataGridView1.TabIndex = 3;
            // 
            // byttonAddGoods
            // 
            this.byttonAddGoods.Location = new System.Drawing.Point(65, 272);
            this.byttonAddGoods.Name = "byttonAddGoods";
            this.byttonAddGoods.Size = new System.Drawing.Size(75, 23);
            this.byttonAddGoods.TabIndex = 1;
            this.byttonAddGoods.Text = "AddGoods";
            this.byttonAddGoods.UseVisualStyleBackColor = true;
            this.byttonAddGoods.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonDeleteGoods
            // 
            this.buttonDeleteGoods.Location = new System.Drawing.Point(545, 272);
            this.buttonDeleteGoods.Name = "buttonDeleteGoods";
            this.buttonDeleteGoods.Size = new System.Drawing.Size(106, 23);
            this.buttonDeleteGoods.TabIndex = 2;
            this.buttonDeleteGoods.Text = "DeleteGoods";
            this.buttonDeleteGoods.UseVisualStyleBackColor = true;
            this.buttonDeleteGoods.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(32, 211);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxOriginCountry
            // 
            this.textBoxOriginCountry.Location = new System.Drawing.Point(167, 211);
            this.textBoxOriginCountry.Name = "textBoxOriginCountry";
            this.textBoxOriginCountry.Size = new System.Drawing.Size(100, 23);
            this.textBoxOriginCountry.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(303, 211);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxDateOfPacking
            // 
            this.textBoxDateOfPacking.Location = new System.Drawing.Point(467, 210);
            this.textBoxDateOfPacking.Name = "textBoxDateOfPacking";
            this.textBoxDateOfPacking.Size = new System.Drawing.Size(100, 23);
            this.textBoxDateOfPacking.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(655, 211);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 23);
            this.textBoxDescription.TabIndex = 8;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(55, 194);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 15);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "OriginCountry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "DateOfPacking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Description";
            // 
            // textBoxPagesAmount
            // 
            this.textBoxPagesAmount.Location = new System.Drawing.Point(32, 317);
            this.textBoxPagesAmount.Name = "textBoxPagesAmount";
            this.textBoxPagesAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxPagesAmount.TabIndex = 14;
            // 
            // textBoxAuthors
            // 
            this.textBoxAuthors.Location = new System.Drawing.Point(32, 383);
            this.textBoxAuthors.Name = "textBoxAuthors";
            this.textBoxAuthors.Size = new System.Drawing.Size(100, 23);
            this.textBoxAuthors.TabIndex = 15;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(208, 316);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(100, 23);
            this.textBoxPublisher.TabIndex = 16;
            // 
            // textBoxDimension
            // 
            this.textBoxDimension.Location = new System.Drawing.Point(655, 317);
            this.textBoxDimension.Name = "textBoxDimension";
            this.textBoxDimension.Size = new System.Drawing.Size(100, 23);
            this.textBoxDimension.TabIndex = 17;
            // 
            // textBoxExpirationDate
            // 
            this.textBoxExpirationDate.Location = new System.Drawing.Point(510, 317);
            this.textBoxExpirationDate.Name = "textBoxExpirationDate";
            this.textBoxExpirationDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxExpirationDate.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "PagesAmount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Publisher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Authors";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "ExpirationDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(678, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dimension";
            // 
            // textBoxAmountInStorage
            // 
            this.textBoxAmountInStorage.Location = new System.Drawing.Point(550, 373);
            this.textBoxAmountInStorage.Name = "textBoxAmountInStorage";
            this.textBoxAmountInStorage.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmountInStorage.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(569, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "AmountInStorage";
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // OriginCountryColumn
            // 
            this.OriginCountryColumn.HeaderText = "OriginCountry";
            this.OriginCountryColumn.Name = "OriginCountryColumn";
            this.OriginCountryColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // DateOfPackingColumn
            // 
            this.DateOfPackingColumn.HeaderText = "DateOfPacking";
            this.DateOfPackingColumn.Name = "DateOfPackingColumn";
            this.DateOfPackingColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // PagesAmountColumn
            // 
            this.PagesAmountColumn.HeaderText = "PagesAmount";
            this.PagesAmountColumn.Name = "PagesAmountColumn";
            this.PagesAmountColumn.ReadOnly = true;
            // 
            // PublisherColumn
            // 
            this.PublisherColumn.HeaderText = "Publisher";
            this.PublisherColumn.Name = "PublisherColumn";
            this.PublisherColumn.ReadOnly = true;
            // 
            // AuthorsColumn
            // 
            this.AuthorsColumn.HeaderText = "Authors";
            this.AuthorsColumn.Name = "AuthorsColumn";
            this.AuthorsColumn.ReadOnly = true;
            // 
            // ExpirationDateColumn
            // 
            this.ExpirationDateColumn.HeaderText = "ExpirationDate";
            this.ExpirationDateColumn.Name = "ExpirationDateColumn";
            this.ExpirationDateColumn.ReadOnly = true;
            // 
            // DimensionColumn
            // 
            this.DimensionColumn.HeaderText = "Dimension";
            this.DimensionColumn.Name = "DimensionColumn";
            this.DimensionColumn.ReadOnly = true;
            // 
            // AmountInStorageColumn
            // 
            this.AmountInStorageColumn.HeaderText = "AmountInStorage";
            this.AmountInStorageColumn.Name = "AmountInStorageColumn";
            this.AmountInStorageColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 538);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxAmountInStorage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxExpirationDate);
            this.Controls.Add(this.textBoxDimension);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxAuthors);
            this.Controls.Add(this.textBoxPagesAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxDateOfPacking);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxOriginCountry);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonDeleteGoods);
            this.Controls.Add(this.byttonAddGoods);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button byttonAddGoods;
        private System.Windows.Forms.Button buttonDeleteGoods;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxOriginCountry;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDateOfPacking;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPagesAmount;
        private System.Windows.Forms.TextBox textBoxAuthors;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxDimension;
        private System.Windows.Forms.TextBox textBoxExpirationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAmountInStorage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginCountryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPackingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagesAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DimensionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountInStorageColumn;
    }
}

