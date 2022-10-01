using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class GeoObject
    {
        protected double XCord { get; set; }
        protected double YCord { get; set; }
        protected string Name { get; set; }
        protected string Description { get; set; }
        public virtual string GetInfo() 
        {
            return "XCord: " + XCord + " YCord: " + YCord + 
                " \nName: " + Name + " \nDescription: " + Description;
        }
    }
}
