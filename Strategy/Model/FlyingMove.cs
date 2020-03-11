using System;
using Strategy.Interfaces;

namespace Strategy.Model
{
    public class FlyingMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car using helicopters for moving");
        }
    }
}