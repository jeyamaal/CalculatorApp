using CalculatorApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorApp.ServiceRegistry
{
    public static class ServiceProviders
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        public static void RegisterServices()
        {
            ServiceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<ICalculatorService, CalculatorService>()
                .BuildServiceProvider();
        }
        public static T GetService<T>() => ServiceProvider.GetService<T>();
    }
}
