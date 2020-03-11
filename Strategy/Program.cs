using Strategy.Model;

namespace Strategy
{
    class Program
    {
        static void Main()
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