using AbstractFactory.Models.Default;

namespace AbstractFactory.Models.Enchanted
{
    public class EnchantedRoom : Room
    {
        private readonly bool _castSpell;

        public EnchantedRoom(int roomNumber, bool castSpell) : base(roomNumber)
        {
            _castSpell = castSpell;
        }

        public bool GetSpell() => _castSpell;
    }
}