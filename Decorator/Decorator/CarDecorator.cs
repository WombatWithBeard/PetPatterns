using Decorator.Models;

namespace Decorator.Decorator
{
    public abstract class CarDecorator : Car
    {
        private readonly Car _car;

        protected CarDecorator(string name, int cost, Car car) : base(name, cost)
        {
            _car = car;
        }
    }
}