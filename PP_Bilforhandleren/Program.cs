namespace PP_Bilforhandleren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller();

            while (true)
            {
                controller.ShowOptions();
                controller.MenuChoice();
            }
        }
    }
}
