using System;

namespace ChainOfResponsibility.Models
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer)
                Console.WriteLine("Bank transfer");
            else
                Successor?.Handle(receiver);
        }
    }
}