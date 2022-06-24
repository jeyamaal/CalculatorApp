using CalculatorApp.ServiceRegistry;

namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           ServiceProviders.RegisterServices();
            
           new App().Run();
        }
    }
}
