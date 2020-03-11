using System;

namespace Mediator.Models
{
    public class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Customer message:" + message);
        }
    }
}