using System;

namespace AbstractFactory.Models.Default
{
    public class Door : BaseRoom
    {
        private readonly Room _room1;
        private readonly Room _room2;
        private bool _isOpen;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public void OtherSideFrom()
        {
            _isOpen = true;
        }

        public override void Enter()
        {
            if (_isOpen)
            {
                Console.WriteLine(
                    $"Вы открываете дверь в команту {_room2.GetRoomNumber()} из комнаты {_room1.GetRoomNumber()}");
            }

            Console.WriteLine("Дверь заперта");
        }
    }
}