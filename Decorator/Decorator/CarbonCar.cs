using Decorator.Models;

namespace Decorator.Decorator
{
    public class CarbonCar : CarDecorator
    {
        public CarbonCar(Car car) : base("Carbon " + car.GetName(), car.GetCost() + 400000, car)
        {
        }
    }
}