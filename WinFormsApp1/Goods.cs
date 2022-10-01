using System;

namespace WinFormsApp1
{
    class Goods {
    
        public double Price { get; set; }
        public string OriginCountry { get; set; }
        public string Name { get; set; }
        public DateTime DateOfPacking { get; set; }
        public string Description { get; set; }

        public Goods(double Price, string OriginCountry, string Name,
            DateTime DateOfPacking, string Description) 
        {
            this.Price = Price;
            this.OriginCountry = OriginCountry;
            this.Name = Name;
            this.DateOfPacking = DateOfPacking;
            this.Description = Description;
        }

        public Goods() { }
    }
}
