using AbstractFactory.Models.Default;

namespace AbstractFactory.Models.Bombed
{
    public class RoomWithABomb : Room
    {
        private readonly bool _hasBomb;
        public RoomWithABomb(int roomNumber, bool hasBomb) : base(roomNumber)
        {
            _hasBomb = hasBomb;
        }

        public bool GetBomb() => _hasBomb;
    }
}