namespace ConsoleApp2
{
    class Mountain : IGeoObject
    {
        private double XCord { get; set; }
        private double YCord { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private (double, double) HighestPoint { get; set; }
        public string GetInfo()
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
