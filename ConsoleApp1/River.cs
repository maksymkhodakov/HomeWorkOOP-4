namespace ConsoleApp1
{
    class River : GeoObject
    {
        private double Speed { get; set; }
        private double TotalLength { get; set; }
        public override string GetInfo()
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
