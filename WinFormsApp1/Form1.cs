using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Goods> Storage = new Dictionary<int, Goods>();
        private static int Counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddDataButtonClick(object sender, EventArgs e)
        {
            if (!(CheckBaseDataIsSet() && ValidateBaseData()))
            {
                MessageBox.Show("Required data is empty or not valid check please!");
            }
            else
            {
                var type = IdentifyType();
                GenerateObject(type);
            }
        }

        private bool CheckBaseDataIsSet() 
        {
            return CheckBaseNotEmpty(textBoxPrice.Text) &&
            CheckBaseNotEmpty(textBoxOriginCountry.Text) &&
            CheckBaseNotEmpty(textBoxName.Text) &&
            CheckBaseNotEmpty(textBoxDateOfPacking.Text) &&
            CheckBaseNotEmpty(textBoxDescription.Text);
        }

        private bool ValidateBaseData() 
        {
            return DataValidator.IsNumeric(textBoxPrice.Text) &&
            DataValidator.IsDateTime(textBoxDateOfPacking.Text);
        }

        private bool CheckBaseNotEmpty(string data) 
        {
            return data.Length != 0; ;
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
                && DataValidator.IsStringValid(textBoxAuthors.Text);
        }

        private bool ProductTypeCheck()
        {
            return DataValidator.IsStringValid(textBoxExpirationDate.Text)
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
                Counter++;
                UploadDataToStorage(Counter, 
                    new Book(double.Parse(textBoxPrice.Text), textBoxOriginCountry.Text, textBoxName.Text, 
                    DateTime.Parse(textBoxDateOfPacking.Text), textBoxDescription.Text, 
                    int.Parse(textBoxPagesAmount.Text), textBoxPublisher.Text, textBoxAuthors.Text));
            }
            else if (type.Equals(StorageTypes.PRODUCT)) {
                this.dataGridView1.Rows.Add(textBoxPrice.Text,
                    textBoxOriginCountry.Text, textBoxName.Text, textBoxDateOfPacking.Text,
                    textBoxDescription.Text,"","","", textBoxExpirationDate.Text,
                    textBoxAmountInStorage.Text, textBoxDimension.Text);
                Counter++;
                UploadDataToStorage(Counter,
                    new Product(double.Parse(textBoxPrice.Text), textBoxOriginCountry.Text, textBoxName.Text,
                    DateTime.Parse(textBoxDateOfPacking.Text), textBoxDescription.Text,
                    DateTime.Parse(textBoxExpirationDate.Text), int.Parse(textBoxAmountInStorage.Text), 
                    textBoxDimension.Text));
            }
            else this.dataGridView1.Rows.Add(textBoxPrice.Text,
                    textBoxOriginCountry.Text, textBoxName.Text, textBoxDateOfPacking.Text,
                    textBoxDescription.Text); // in storage there is no type for this
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
                DeleteDataFromStorage(index);
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }
        
        private void UploadDataToStorage(int index, Goods goods) 
        {
            Storage.Add(index, goods);
        }
        private void DeleteDataFromStorage(int index) 
        {
            Storage.Remove(index);
        }

        private void ExportData(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        DataGridViewCell cell = this.dataGridView1.Rows[i].Cells[j];
                        if (cell != null && !String.IsNullOrEmpty(cell.Value as string))
                        {
                            XcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No data to export");
            }
        }
    }
}
