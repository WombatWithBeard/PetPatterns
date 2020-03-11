using System;

namespace Mediator.Models
{
    public class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Programmer message:" + message);
        }
    }
}