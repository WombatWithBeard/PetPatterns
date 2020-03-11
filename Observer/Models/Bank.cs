using System;
using Observer.Interfaces;

namespace Observer.Models
{
    public class Bank : IObserver
    {
        private readonly string _name;
        private IObservable _observable;

        public Bank(string name, IObservable observable)
        {
            _name = name;
            _observable = observable;
            _observable.RegisterObserver(this);
        }

        public void Update(object o)
        {
            var stockInfo = (StockInfo) o;

            Console.WriteLine(stockInfo.Usd > 500
                ? $"Bank {_name} sell USD {stockInfo.Usd}"
                : $"Bank {_name} buy USD {stockInfo.Usd}");
            Console.WriteLine(stockInfo.Euro > 50
                ? $"Bank {_name} sell USD {stockInfo.Euro}"
                : $"Bank {_name} buy USD {stockInfo.Euro}");
            Console.WriteLine(stockInfo.Rub > 33
                ? $"Bank {_name} sell USD {stockInfo.Rub}"
                : $"Bank {_name} buy USD {stockInfo.Rub}");
        }

        public void StopTrade()
        {
            _observable.RemoveObserver(this);
            _observable = null;
        }
    }
}