using Module3HW4.Models;
using Module3HW4.Models.Plants;
using Module3HW4.Services.Abstractions;
namespace Module3HW4.Services
{
    public class FenseService : IFenceService
    {
        public double Square(Space space)
        {
            // logic - add several plants within a fence
            return space.Value;
        }
    }
}
