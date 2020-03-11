using System;

namespace ChainOfResponsibility.Models
{
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer)
                Console.WriteLine("Money transfer");
            else
                Successor?.Handle(receiver);
        }
    }
}