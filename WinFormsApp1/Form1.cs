using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Goods> Goods = new List<Goods>() {
            new Goods(12.2, "USA", "Cool goods", new DateTime(), "SuperDescription"),
            new Goods(121.22, "Canada", "Not so cool", new DateTime(), "Informative"),
            new Book(121.211, "Ukraine", "Kobzar", new DateTime(), "The greatest!",
                1000, "Taras Shevchenko", new List<string>())
        };
        public Form1()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData() 
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = Goods;
        }

        private void AddDataButtonClick(object sender, EventArgs e)
        {
            // test data to add
            // TODO: GET DATA FROM REMOTE STORAGE!!!
            Goods.Add(new Goods(331.22, "Japan", "so cool", new DateTime(), "TEST"));
            ShowData();
        }

        private void DeleteDataButtonClick(object sender, EventArgs e)
        {
            if (Goods.Count > 0)
            {
                Goods.RemoveAt(Goods.Count - 1);
                ShowData();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }
    }
}
