using System;

namespace ChainOfResponsibility.Models
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer)
                Console.WriteLine("PayPal transfer");
            else
                Successor?.Handle(receiver);
        }
    }
}