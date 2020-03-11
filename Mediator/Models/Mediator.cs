namespace Mediator.Models
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
}