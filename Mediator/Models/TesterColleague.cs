using System;

namespace Mediator.Models
{
    public class TesterColleague : Colleague
    {
        public TesterColleague(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Tester message:" + message);
        }
    }
}