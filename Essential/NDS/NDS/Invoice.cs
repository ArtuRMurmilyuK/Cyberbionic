using System;

namespace NDS
{
    class Invoice
    {
        private int _account { get; set; }
        private string _customer { get; set; }
        private string _provider { get; set; }

        private string article;
        private int quantity;

        public void Init(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;

            Console.Write("Enter name customer: ");
            customer = Console.ReadLine();

            provider = "Melnik O.M.";

            Console.Write("Enter article: ");
            article = Console.ReadLine();
            var price = 0;
            switch (article)
            {
                case "Book":
                    Console.Write("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());

                    price = 12;

                    Console.WriteLine("Customer: " + customer);
                    Console.WriteLine("Provider: " + provider);

                    Price(quantity, price, out account);
                    break;

                case "Notebook":
                    Console.Write("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());

                    price = 5;

                    Console.WriteLine("Customer: " + customer);
                    Console.WriteLine("Provider: " + provider);

                    Price(quantity, price, out account);
                    break;

                case "Pan":
                    Console.Write("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());

                    price = 2;

                    Console.WriteLine("Customer: " + customer);
                    Console.WriteLine("Provider: " + provider);

                    Price(quantity, price, out account);
                    break;
            }

        }
        
        public void Price(int quantity, int price, out int account)
        {
            account = price * quantity;
            var nds = account * 20 / 100;
            Console.WriteLine("Price without VAT: " + account);
            Console.WriteLine("Price wit VAT: " + (account + nds));
        }
    }
}
