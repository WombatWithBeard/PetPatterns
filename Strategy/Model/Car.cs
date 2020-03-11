using Strategy.Interfaces;

namespace Strategy.Model
{
    public class Car : IMovable
    {
        private IMovable _movable;

        public Car(IMovable movable)
        {
            _movable = movable;
        }

        public void SetMovable(IMovable movable)
        {
            _movable = movable;
        }
        
        public void Move()
        {
            _movable.Move();
        }
    }
}