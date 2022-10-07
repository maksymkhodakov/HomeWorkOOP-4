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

        private void Button1_Click(object sender, EventArgs e)
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
            if (!String.IsNullOrEmpty(textBoxPagesAmount.Text)
                && !String.IsNullOrEmpty(textBoxPublisher.Text)
                && !String.IsNullOrEmpty(textBoxAuthors.Text)
                && DataValidator.IsNumeric(textBoxPagesAmount.Text)) return StorageTypes.BOOK;
            else if (!String.IsNullOrEmpty(textBoxExpirationDate.Text)
                && DataValidator.IsDateTime(textBoxExpirationDate.Text)
                && !String.IsNullOrEmpty(textBoxAmountInStorage.Text)
                && DataValidator.IsNumeric(textBoxAmountInStorage.Text)
                && !String.IsNullOrEmpty(textBoxDimension.Text)) return StorageTypes.PRODUCT;
            else return StorageTypes.NOT_INCLUDED;
        }

        private void GenerateObject(StorageTypes type) 
        {
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

        private void Button2_Click(object sender, EventArgs e)
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
