namespace Decorator.Models
{
    public abstract class Car
    {
        private readonly string _name;
        private readonly int _cost;

        protected Car(string name, int cost)
        {
            _name = name;
            _cost = cost;
        }

        public int GetCost() => _cost;
        public string GetName() => _name;
    }
}