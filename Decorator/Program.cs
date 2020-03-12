using System;
using Decorator.Decorator;
using Decorator.Models;

namespace Decorator
{
    internal class Program
    {
        private static void Main()
        {
            Car ferrari = new Ferrari();
            WriteCarData(ferrari);
            
            ferrari = new RedCar(ferrari);
            WriteCarData(ferrari);
            
            Car zonda = new Zonda();
            WriteCarData(zonda);
            
            zonda = new CarbonCar(zonda);
            WriteCarData(zonda);
            
            zonda = new RedCar(zonda);
            WriteCarData(zonda);
        }

        private static void WriteCarData(Car car)
        {
            Console.WriteLine(car.GetName() + " cost: " + car.GetCost());
        }
    }
}