using System;
using System.Threading.Channels;
using State.Interfaces;

namespace State.Models
{
    public class GasWaterState : IWaterState
    {
        public void HeatUp(Water water)
        {
            Console.WriteLine("Heat up steam");
        }

        public void Chilled(Water water)
        {
            Console.WriteLine("turn steam into liquid");
            water.State = new LiquidWaterState();
        }
    }
}