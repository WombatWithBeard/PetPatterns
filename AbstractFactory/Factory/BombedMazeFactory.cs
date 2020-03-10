using AbstractFactory.Models.Bombed;
using AbstractFactory.Models.Default;

namespace AbstractFactory.Factory
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int n)
        {
            return new RoomWithABomb(n, CreateBomb());
        }

        private bool CreateBomb()
        {
            return true;
        }
    }
}