using AbstractFactory.Models.Default;
using AbstractFactory.Models.Enchanted;

namespace AbstractFactory.Factory
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        private bool CastSpell()
        {
            return true;
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }
    }
}