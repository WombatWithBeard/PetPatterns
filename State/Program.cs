using State.Models;

namespace State
{
    internal class Program
    {
        private static void Main()
        {
            var water = new Water(new LiquidWaterState());
            water.HeatUp();
            water.Chilled();
            water.Chilled();
        }
    }
}