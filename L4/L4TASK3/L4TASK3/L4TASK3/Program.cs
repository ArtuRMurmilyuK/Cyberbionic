using System;
using System.Threading;


namespace L4TASK3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select word for translate :Дождь, Снег, Солнце, Облачно, Град, Шторм, Потоп, Безоблачный, Ветер, Гололёд");
            string words= Console.ReadLine();
            switch (words)
            {
                case "Дождь":
                {
                    Console.WriteLine("Rain");
                    Console.ReadKey();
                    break;
                }
                case "Снег":
                {
                    Console.WriteLine("Snow");
                    Console.ReadKey();
                    break;
                }
                case "Солнце":
                {
                    Console.WriteLine("The sun");
                    Console.ReadKey();
                    break;
                }
                case "Облачно":
                {
                    Console.WriteLine("Cloudy");
                    Console.ReadKey();
                    break;
                }
                case "Град":
                {
                    Console.WriteLine("Hail");
                    Console.ReadKey();
                    break;
                }
                case "Шторм":
                {
                    Console.WriteLine("Storm");
                    Console.ReadKey();
                    break;
                }
                case "Потоп":
                {
                    Console.WriteLine("Deluge");
                    Console.ReadKey();
                    break;
                }
                case "Безоблачный":
                {
                    Console.WriteLine("Cloudless");
                    Console.ReadKey();
                    break;
                }
                case "Ветер":
                {
                    Console.WriteLine("Wind");
                    Console.ReadKey();
                    break;
                }
                case "Гололёд":
                {
                    Console.WriteLine("Ice");
                    Console.ReadKey();
                    break;
                }
                default:
                {
                    Console.WriteLine("This word is not in the dictionary.");
                    Console.ReadKey();
                    break;
                }

            }
        }
    }
}
