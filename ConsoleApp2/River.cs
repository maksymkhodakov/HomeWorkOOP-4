using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class River : IGeoObject
    {
        private double Speed { get; set; }
        private double TotalLength { get; set; }
        private double XCord { get; set; }
        private double YCord { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        public string GetInfo()
        {
            return "XCord: " + XCord + " YCord: " + YCord +
                " \nName: " + Name + " \nDescription: " + Description +
                " \nRiver Speed: " + Speed + " \nTotal Length: " + TotalLength;
        }
        public River(double XCord, double YCord, string Name, string Description, 
            double Speed, double TotalLength)
        {
            this.XCord = XCord;
            this.YCord = YCord;
            this.Name = Name;
            this.Description = Description;
            this.Speed = Speed;
            this.TotalLength = TotalLength;
        }
    }
}
