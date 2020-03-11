using State.Models;

namespace State
{
    class Program
    {
        static void Main()
        {
            var water = new Water(new LiquidWaterState());
            water.HeatUp();
            water.Chilled();
            water.Chilled();
        }
    }
}