namespace ConsoleApp1
{
    class Mountain : GeoObject
    {
        private (double, double) HighestPoint { get; set; }
        public override string GetInfo()
        {
            return "XCord: " + XCord + " YCord: " + YCord +
                " \nName: " + Name + " \nDescription: " + Description +
                " \nHighest Point Coordinates: " + HighestPoint.Item1 + " " + HighestPoint.Item2;
        }

        public Mountain(double XCord, double YCord, string Name, string Description,
            (double, double) HighestPoint)
        {
            this.XCord = XCord;
            this.YCord = YCord;
            this.Name = Name;
            this.Description = Description;
            this.HighestPoint = HighestPoint;
        }
    }
}
