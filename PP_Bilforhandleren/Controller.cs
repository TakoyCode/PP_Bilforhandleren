namespace PP_Bilforhandleren
{
    internal class Controller
    {
        private Person customer; 
        private Person dealer; 

        public Controller()
        {
            customer = new Person();
            dealer = new Person([
                new Car("Toyata", 2001, 24, 223),
                new Car("Volva", 1988, 12, 465),
                new Car("Audi", 2010, 60, 142),
            ]);
        }

        public void ShowOptions()
        {
            Console.WriteLine("1) Show dealers cars");
            Console.WriteLine("2) Filter by year made");
            Console.WriteLine("3) Filter by Millage");
            Console.WriteLine("4) Buy car");
            Console.WriteLine("5) Show my car");
        }

        public void MenuChoice()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    dealer.ShowMyCars();
                    break;
                case "2":
                    dealer.ShowCarsByYearMade();
                    break;
                case "3":
                    dealer.ShowCarsByMillage();
                    break;
                case "4":
                    dealer.ShowMyCars();
                    BuyCar(customer, dealer);
                    break;
                case "5":
                    customer.ShowMyCars();
                    break;
                default:
                    break;
            }
        }

        public static int AskForStringAndReturnNum()
        {
            int num;
            string numStr = Console.ReadLine();

            if (!int.TryParse(numStr, out num))
            {
                Console.WriteLine("Try again");
                return AskForStringAndReturnNum();
            }
            return num;
        }

        public static void BuyCar(Person customer, Person seller)
        {
            int carIndex = AskForStringAndReturnNum();

            Car car = seller.Cars[carIndex];
            customer.Cars.Add(car);
            seller.Cars.RemoveAt(carIndex);

            Console.WriteLine($"You now own a {car.Brand}!");
        }
    }
}
