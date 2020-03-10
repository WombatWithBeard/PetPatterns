using System.Collections.Generic;
using AbstractFactory.Models.Default;

namespace AbstractFactory.Models
{
    public class Maze
    {
        private readonly List<Room> _rooms;
        public Maze()
        {
            _rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public List<Room> GetRooms() => _rooms;
    }
}