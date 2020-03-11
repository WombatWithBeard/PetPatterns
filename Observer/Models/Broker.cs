using System;
using Observer.Interfaces;

namespace Observer.Models
{
    public class Broker : IObserver
    {
        private readonly string _name;
        private IObservable _observable;

        public Broker(string name, IObservable observable)
        {
            _name = name;
            _observable = observable;
            _observable.RegisterObserver(this);
        }

        public void Update(object o)
        {
            var stockInfo = (StockInfo) o;

            Console.WriteLine(stockInfo.Usd > 500
                ? $"Broker {_name} sell USD {stockInfo.Usd}"
                : $"Broker {_name} buy USD {stockInfo.Usd}");
            Console.WriteLine(stockInfo.Euro > 50
                ? $"Broker {_name} sell USD {stockInfo.Euro}"
                : $"Broker {_name} buy USD {stockInfo.Euro}");
            Console.WriteLine(stockInfo.Rub > 33
                ? $"Broker {_name} sell USD {stockInfo.Rub}"
                : $"Broker {_name} buy USD {stockInfo.Rub}");
        }

        public void StopTrade()
        {
            _observable.RemoveObserver(this);
            _observable = null;
        }
    }
}