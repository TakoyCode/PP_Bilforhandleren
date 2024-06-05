namespace PP_Bilforhandleren
{
    internal class Car
    {
        public string Brand { get; }
        public int YearMade { get; }
        public int Registration { get; }
        public int Millage { get; }

        public Car(string brand, int yearMade, int registration, int millage)
        {
            Brand = brand;
            YearMade = yearMade;
            Registration = registration;
            Millage = millage;
        }
    }
}
