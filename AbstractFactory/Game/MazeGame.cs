using AbstractFactory.Factory;
using AbstractFactory.Models;
using AbstractFactory.Utilities;

namespace AbstractFactory.Game
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeFactory factory)
        {
            var maze = factory.MakeMaze();
            var room1 = factory.MakeRoom(1);
            var room2 = factory.MakeRoom(2);
            var theDoor = factory.MakeDoor(room1, room2);

            room1.SetSide(Direction.North, factory.MakeWall());
            room1.SetSide(Direction.East, theDoor);
            room1.SetSide(Direction.South, factory.MakeWall());
            room1.SetSide(Direction.West, factory.MakeWall());
            
            room2.SetSide(Direction.North, factory.MakeWall());
            room2.SetSide(Direction.East, factory.MakeWall());
            room2.SetSide(Direction.South, factory.MakeWall());
            room2.SetSide(Direction.West, theDoor);
            
            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }
    }
}