namespace PP_Bilforhandleren
{
    internal class Person
    {
        public List<Car> Cars;

        public Person()
        {
            Cars = new List<Car>();
        }

        public Person(List<Car> cars)
        {
            Cars = cars;
        }

        public void ShowMyCars()
        {
            for (var index = 0; index < Cars.Count; index++)
            {
                var car = Cars[index];
                Console.WriteLine(
                    index + " - " +
                    car.Brand + " " +
                    car.YearMade + " " +
                    car.Registration + " " +
                    car.Millage);
            }
        }

        public void ShowCarsByYearMade()
        {
            var year1 = Controller.AskForStringAndReturnNum();
            var year2 = Controller.AskForStringAndReturnNum();

            for (var index = 0; index < Cars.Count; index++)
            {
                var car = Cars[index];
                if (car.YearMade >= year1 && car.YearMade <= year2)
                {
                    Console.WriteLine(
                        car.Brand + " " +
                        car.YearMade + " " +
                        car.Registration + " " +
                        car.Millage);
                }
            }
        }

        public void ShowCarsByMillage()
        {
            var millage1 = Controller.AskForStringAndReturnNum();
            var millage2 = Controller.AskForStringAndReturnNum();

            foreach (var car in Cars)
            {
                if (car.Millage >= millage1 && car.Millage <= millage2)
                {
                    Console.WriteLine(
                        car.Brand + " " +
                        car.YearMade + " " +
                        car.Registration + " " +
                        car.Millage);
                }
            }
        }
    }
}
