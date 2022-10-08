using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddDataButtonClick(object sender, EventArgs e)
        {
            CheckBaseDataIsSet();
            ValidateBaseData();
            var type = IdentifyType();
            GenerateObject(type);
        }

        private void CheckBaseDataIsSet() 
        {
            CheckBaseNotEmpty(textBoxPrice.Text);
            CheckBaseNotEmpty(textBoxOriginCountry.Text);
            CheckBaseNotEmpty(textBoxName.Text);
            CheckBaseNotEmpty(textBoxDateOfPacking.Text);
            CheckBaseNotEmpty(textBoxDescription.Text);
        }

        private void ValidateBaseData() 
        {
            DataValidator.IsNumeric(textBoxPrice.Text);
            DataValidator.IsDateTime(textBoxDateOfPacking.Text);
        }

        private bool CheckBaseNotEmpty(string data) 
        {
            if (data.Length == 0) {
                MessageBox.Show("Required data is empty");
            }
            return true;
        }

        private StorageTypes IdentifyType() 
        {
            // check type of goods
            if (BookTypeCheck() && ProductTypeCheck()) return StorageTypes.NOT_INCLUDED;
            else if (BookTypeCheck()) return StorageTypes.BOOK;
            else if (ProductTypeCheck()) return StorageTypes.PRODUCT;
            else return StorageTypes.NOT_INCLUDED;
        }

        private bool BookTypeCheck() 
        {
            return DataValidator.IsStringValid(textBoxPagesAmount.Text)
                && DataValidator.IsStringValid(textBoxPublisher.Text)
                && DataValidator.IsStringValid(textBoxAuthors.Text)
                && DataValidator.IsNumeric(textBoxPagesAmount.Text);
        }

        private bool ProductTypeCheck() 
        {
            return DataValidator.IsStringValid(textBoxExpirationDate.Text)
                && DataValidator.IsDateTime(textBoxExpirationDate.Text)
                && DataValidator.IsStringValid(textBoxAmountInStorage.Text)
                && DataValidator.IsNumeric(textBoxAmountInStorage.Text)
                && DataValidator.IsStringValid(textBoxDimension.Text);
        }

        private void GenerateObject(StorageTypes type) 
        {
            // fill data in new row
            if (type.Equals(StorageTypes.BOOK))
            {
                this.dataGridView1.Rows.Add(textBoxPrice.Text,
                    textBoxOriginCountry.Text, textBoxName.Text, textBoxDateOfPacking.Text,
                    textBoxDescription.Text, textBoxPagesAmount.Text, textBoxPublisher.Text,
                    textBoxAuthors.Text);
            }
            else if (type.Equals(StorageTypes.PRODUCT)) {
                this.dataGridView1.Rows.Add(textBoxPrice.Text,
                    textBoxOriginCountry.Text, textBoxName.Text, textBoxDateOfPacking.Text,
                    textBoxDescription.Text,"","","", textBoxExpirationDate.Text,
                    textBoxAmountInStorage.Text, textBoxDimension.Text);
            } else this.dataGridView1.Rows.Add(textBoxPrice.Text,
                    textBoxOriginCountry.Text, textBoxName.Text, textBoxDateOfPacking.Text,
                    textBoxDescription.Text);
        }

        private void DeleteDataButtonClick(object sender, EventArgs e)
        {
            DeleteRow();
        }
        private void DeleteRow() 
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                int index = this.dataGridView1.CurrentCell.RowIndex;
                this.dataGridView1.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }
    }
}
