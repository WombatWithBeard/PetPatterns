using System;
using State.Interfaces;

namespace State.Models
{
    public class LiquidWaterState : IWaterState
    {
        public void HeatUp(Water water)
        {
            Console.WriteLine("turn liquid into steam");
            water.State = new GasWaterState();
        }

        public void Chilled(Water water)
        {
            Console.WriteLine("turn liquid into ice");
            water.State = new SolidWaterState();
        }
    }
}