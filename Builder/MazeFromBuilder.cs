using AbstractFactory.Factory;
using AbstractFactory.Models;
using Builder.Utilities;

namespace Builder
{
    public class MazeFromBuilder
    {
        public Maze CreateMaze()
        {
            IMazeBuilder builder = new StandardMazeBuilder(new MazeFactory());
            var game = new MazeGameBuilder();

            game.CreateMaze(builder);
            var maze = builder.GetMaze();

            return maze;
        }
    }
}