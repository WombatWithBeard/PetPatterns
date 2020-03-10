using System;
using System.Collections.Generic;
using AbstractFactory.Utilities;

namespace AbstractFactory.Models.Default
{
    public class Room : BaseRoom
    {
        private readonly int _roomNumber;
        private readonly Dictionary<Direction, BaseRoom> _sides;

        public Room(int roomNumber)
        {
            _roomNumber = roomNumber;
            _sides = new Dictionary<Direction, BaseRoom>();
        }

        public override void Enter()
        {
            Console.WriteLine($"Вы входите в комнату {_roomNumber}");
        }

        public void SetSide(Direction direction, BaseRoom wall)
        {
            _sides.Add(direction, wall);
        }

        public Dictionary<Direction, BaseRoom> GetSides() => _sides;

        public int GetRoomNumber() => _roomNumber;
    }
}