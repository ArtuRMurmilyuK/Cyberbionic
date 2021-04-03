using System;
using System.Collections.Generic;

namespace DryCleaningApp
{
    class Program
    {
        static void Main()
        {
            Stock stock = new Stock();
            
            Client client = new Client("Olga", stock);
            
            stock.InitItem("Dress");
            
            var client1 = new Client("Max", stock);
            var cleaningService = new CleaningService(client1.Name, stock);

            cleaningService.ItemIsReady += MessageHandler;

            stock.InitItem("shorts");

            Console.Read();
        }

        private static void MessageHandler(object sender, string messageFromTheService) 
        {
            Console.WriteLine($"Dear {sender}," + messageFromTheService);
        }
    }

    interface IObserver
    {
        void Update(Object ob);
    }

    interface IObservable
    {
        void RegisterObserver(IObserver o);
    }

    class Stock : IObservable
    {
        private readonly StockInfo _sInfo;

        private readonly List<IObserver> _observers;
        public Stock()
        {
            _observers = new List<IObserver>();
            _sInfo = new StockInfo();
        }
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(_sInfo);
            }
        }

        public void InitItem(string item)
        {
            _sInfo.ItemName = item;
            NotifyObservers();
        }
    }

    class StockInfo
    {
        public string ItemName { get; set; }
    }

    class Client : IObserver
    {
        public string Name { get; set; }

        public Client(string name, IObservable obs)
        {
            Name = name;
            obs.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            Console.WriteLine($"{Name} brought {sInfo.ItemName}.");
        }
    }

    class CleaningService : IObserver
    {
        public string Name { get; set; }

        public event EventHandler<string> ItemIsReady;

        public CleaningService(string name, IObservable obs)
        {
            Name = name;
            obs.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            Console.WriteLine("{0}, we clean your {1} ", Name , sInfo.ItemName);

            ItemIsReady?.Invoke(Name, $"your {sInfo.ItemName} are ready");
        }
    }
}
