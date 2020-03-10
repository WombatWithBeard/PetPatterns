using AbstractFactory.Models;

namespace Builder.Utilities
{
    public class MazeGameBuilder
    {
        public Maze CreateMaze(IMazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
            
            return builder.GetMaze();
        }
    }
}