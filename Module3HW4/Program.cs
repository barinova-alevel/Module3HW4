using Module3HW4.Providers;
using Module3HW4.Providers.Abstractions;
using Module3HW4.Services;
using Module3HW4.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Module3HW4
{
    using System;
    public class Program
    {
       public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IPlantsProvider, PlantsProvider>()
                .AddSingleton<IFenceService, FenseService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
