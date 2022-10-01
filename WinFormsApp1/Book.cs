using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Book : Goods
    {
        public int PagesAmount { get; set; }
        public string Publisher { get; set; }
        public List<string> Authors = new List<string>();
        public void AddAuthor(string name)
        {
            Authors.Add(name);
        }

        public void DeleteAuthor(string name)
        {
            if (Authors.Contains(name))
            {
                Authors.Remove(name);
            }
        }

        public Book(double Price, string OriginCountry, string Name,
          DateTime DateOfPacking, string Description, int PagesAmount, string Publisher,
          List<string> Authors)
        {
            this.Price = Price;
            this.OriginCountry = OriginCountry;
            this.Name = Name;
            this.DateOfPacking = DateOfPacking;
            this.Description = Description;
            this.PagesAmount = PagesAmount;
            this.Publisher = Publisher;
            this.Authors = Authors;
        }
    }
}
