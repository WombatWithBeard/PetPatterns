﻿using Observer.Models;

namespace Observer
{
    internal class Program
    {
        private static void Main()
        {
            var stock = new Stock();
            var bank = new Bank("TestBank", stock);
            var broker = new Broker("TestBroker", stock);
            
            stock.Market();
            
            broker.StopTrade();
            
            stock.Market();
            
            bank.StopTrade();
            
            stock.Market();
        }
    }
}