namespace Mediator.Models
{
    public abstract class Colleague
    {
        private readonly Mediator _mediator;

        protected Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void Notify(string message);
    }
}