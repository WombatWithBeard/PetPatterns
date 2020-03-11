using State.Interfaces;

namespace State.Models
{
    public class Water
    {
        public IWaterState State;

        public Water(IWaterState state)
        {
            State = state;
        }

        public void HeatUp()
        {
            State.HeatUp(this);
        }

        public void Chilled()
        {
            State.Chilled(this);
        }
    }
}