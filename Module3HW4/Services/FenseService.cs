using System;
using Module3HW4.Models;
using Module3HW4.Models.Plants;
using Module3HW4.Providers;
using Module3HW4.Services.Abstractions;

namespace Module3HW4.Services
{
    public class FenseService : IFenceService
    {
       public int FenceLength()
        {
            Console.WriteLine("Fence length:");
            return (int)(Math.Sqrt(GetSquare()) * 4) + 1;
        }

       public double GetSquare()
         {
            /* PlantsProvider plants = new PlantsProvider();
            double commonSpace = 0;
            foreach (Plant plant in plants)
            {
                commonSpace += plant.Space.Value;
            }

            return commonSpace; */
            return 10.0;
         }
    }
}
