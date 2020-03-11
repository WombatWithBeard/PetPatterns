using System;

namespace Observer.Interfaces
{
    public interface IObserver
    {
        void Update(Object o);
        void StopTrade();
    }
}