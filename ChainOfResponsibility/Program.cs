using ChainOfResponsibility.Models;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            var receiver = new Receiver(false, true, false);
            
            var bank = new BankPaymentHandler();
            var paypal = new PayPalPaymentHandler();
            var money = new MoneyPaymentHandler();

            bank.Successor = paypal;
            paypal.Successor = money;
            
            bank.Handle(receiver);
        }
    }
}