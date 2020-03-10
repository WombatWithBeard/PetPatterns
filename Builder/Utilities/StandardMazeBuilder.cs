using AbstractFactory.Factory;
using AbstractFactory.Models;
using AbstractFactory.Models.Default;
using AbstractFactory.Utilities;

namespace Builder.Utilities
{
    public class StandardMazeBuilder : IMazeBuilder
    {
        private readonly MazeFactory _factory;
        private Maze _maze;

        public StandardMazeBuilder(MazeFactory factory)
        {
            _factory = factory;
        }
        
        public void BuildMaze()
        {
            _maze = new Maze();
        }

        public void BuildRoom(int number)
        {
            var room = new Room(number);

            switch (number)
            {
                case 1:
                    room.SetSide(Direction.North, _factory.MakeWall());
                    room.SetSide(Direction.East, _factory.MakeWall());
                    room.SetSide(Direction.South, _factory.MakeWall());
                    room.SetSide(Direction.West, _factory.MakeWall());
                    break;
                case 2:
                    room.SetSide(Direction.North, _factory.MakeWall());
                    room.SetSide(Direction.East, _factory.MakeWall());
                    room.SetSide(Direction.South, _factory.MakeWall());
                    room.SetSide(Direction.West, _factory.MakeWall());
                    break;
            }
            
            _maze.AddRoom(room);
        }

        public void BuildDoor(int roomFrom, int roomTo)
        {
            var r1 = _maze.GetRoom(roomFrom);
            var r2 = _maze.GetRoom(roomTo);
            
            var door = _factory.MakeDoor(r1, r2);
            r1.SetSide(CommonWall(r1, r2), door);
            r2.SetSide(CommonWall(r2, r1), door);
        }

        private Direction CommonWall(Room r1, Room r2)
        {
            
            if (_i % 2 == 0)
            {
                _i++;
                return Direction.North;
            }
            
            _i++;
            return Direction.South;

        }

        private static int _i = 1;

        public Maze GetMaze() => _maze;
    }
}