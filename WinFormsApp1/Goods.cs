using System;

namespace WinFormsApp1
{
    abstract class Goods {
    
        public double Price { get; set; }
        public string OriginCountry { get; set; }
        public string Name { get; set; }
        public DateTime DateOfPacking { get; set; }
        public string Description { get; set; }
    }
}
