using System;
using State.Interfaces;

namespace State.Models
{
    public class SolidWaterState : IWaterState
    {
        public void HeatUp(Water water)
        {
            Console.WriteLine("Warm the ice");
            water.State = new LiquidWaterState();
        }

        public void Chilled(Water water)
        {
            Console.WriteLine("Froze the ice");
        }
    }
}