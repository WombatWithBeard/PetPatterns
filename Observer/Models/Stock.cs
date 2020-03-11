using System;
using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer.Models
{
    public class Stock : IObservable
    {
        private readonly List<IObserver> _observers;
        private readonly StockInfo _stockInfo;

        public Stock()
        {
            _observers = new List<IObserver>();
            _stockInfo = new StockInfo();
        }

        public void Market()
        {
            var rnd = new Random();
            _stockInfo.Euro = rnd.Next(10, 100);
            _stockInfo.Rub = rnd.Next(30, 35);
            _stockInfo.Usd = rnd.Next(100, 1000);
            NotifyObservers();
        }
        
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_stockInfo));
        }
    }
}