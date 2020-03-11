using Decorator.Models;

namespace Decorator.Decorator
{
    public class RedCar : CarDecorator
    {
        public RedCar(Car car) : base("Red " + car.GetName(), car.GetCost() + 9999999, car)
        {
        }
    }
}