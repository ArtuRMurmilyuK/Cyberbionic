using System;

namespace DryCleaningApp
{
    class Program
    {
        static void Main()
        {
            var dryCleaningService = new DryCleaningService();

            dryCleaningService.ItemIsReady += MessageHandler;
            dryCleaningService.CleanItem(new Client() { ClientName = "Ivan Ivanich" }, new Item() { ItemType = "Dress" });
            dryCleaningService.CleanItem(new Client() { ClientName = "Petro" }, new Item() { ItemType = "Suit" });

            dryCleaningService.ItemIsReady -= MessageHandler;
            dryCleaningService.CleanItem(new Client() { ClientName = "Oleg" }, new Item() { ItemType = "Trousers" });
        }

        private static void MessageHandler(object sender, string messageFromTheService)
        {
            Console.WriteLine($"Dear {sender}, your " + messageFromTheService);
        }

    }

    public class Item
    {
        public string ItemType { get; set; }
    }

    public class Client
    {
        public string ClientName { get; set; }
    }

    public class DryCleaningService
    {
        public event EventHandler<string> ItemIsReady;

        public void CleanItem(Client someClient, Item someItem)
        {
            Console.WriteLine("object cleaning");
            Console.WriteLine("finished working");

            ItemIsReady?.Invoke(someClient.ClientName, $"item {someItem.ItemType} is ready.");
        }
    }
}
