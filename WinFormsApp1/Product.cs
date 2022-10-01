using System;

namespace WinFormsApp1
{
    class Product : Goods
    {
        public DateTime ExpirationDate { get; set; }
        public int AmountInStorage { get; set; }
        public string NameOfDimension { get; set; }

        public Product(double Price, string OriginCountry, string Name,
            DateTime DateOfPacking, string Description, DateTime ExpirationDate,
            int AmountInStorage, string NameOfDimension)
        {
            this.Price = Price;
            this.OriginCountry = OriginCountry;
            this.Name = Name;
            this.DateOfPacking = DateOfPacking;
            this.Description = Description;
            this.ExpirationDate = ExpirationDate;
            this.AmountInStorage = AmountInStorage;
            this.NameOfDimension = NameOfDimension;
        }
    }
}
