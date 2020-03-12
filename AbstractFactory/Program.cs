using AbstractFactory.Factory;
using AbstractFactory.Game;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main()
        {
            var defaultGame = new MazeGame().CreateMaze(new MazeFactory());
            var enchantedGame = new MazeGame().CreateMaze(new EnchantedMazeFactory());
            var bombedGame = new MazeGame().CreateMaze(new BombedMazeFactory());
        }
    }
}