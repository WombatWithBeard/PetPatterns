using System;
using Strategy.Interfaces;

namespace Strategy.Model
{
    public class DefaultMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car using wheels for movement");
        }
    }
}