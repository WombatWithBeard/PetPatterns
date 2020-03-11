using State.Models;

namespace State.Interfaces
{
    public interface IWaterState
    {
        void HeatUp(Water water);
        void Chilled(Water water);
    }
}