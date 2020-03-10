using AbstractFactory.Models;

namespace Builder.Utilities
{
    public interface IMazeBuilder
    {
        public void BuildMaze();
        public void BuildRoom(int number);
        public void BuildDoor(int roomFrom, int roomTo);

        public Maze GetMaze();
    }
}