using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GeoObject river = new River(1.1, 1.2, "Dnipro", "The greatest", 12.4, 13242.23);
            Console.WriteLine(river.GetInfo());

            Console.WriteLine("\n\n");

            GeoObject mountain = new Mountain(1.1, 1.2, "Hoverla", "The greatest", (13242.23, 1241.214));
            Console.WriteLine(mountain.GetInfo());
        }
    }
}
