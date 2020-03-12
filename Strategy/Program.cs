using Strategy.Model;

namespace Strategy
{
    internal class Program
    {
        private static void Main()
        {
            var car = new Car(new DefaultMove());
            car.Move();
            
            car.SetMovable(new FlyingMove());
            car.Move();
            
            car.SetMovable(new StrangeMove());
            car.Move();
        }
    }
}