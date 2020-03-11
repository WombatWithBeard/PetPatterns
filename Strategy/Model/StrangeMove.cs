using System;
using Strategy.Interfaces;

namespace Strategy.Model
{
    public class StrangeMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car moving strange");
        }
    }
}