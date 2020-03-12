using Mediator.Models;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            var mediator = new ManagerMediator();
            var customer = new CustomerColleague(mediator);
            var programmer = new ProgrammerColleague(mediator);
            var tester = new TesterColleague(mediator);

            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            
            customer.Send("One more task");
            programmer.Send("Merge task");
            tester.Send("Pipeline passed");
        }
    }
}