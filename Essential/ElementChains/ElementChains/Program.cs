using System;
using System.Linq;
using System.Threading;
using System.Threading.Channels;

namespace ElementChains
{
    class Program
    {
        static object locker = new object();
        private static Random random = new Random();
        private static int randomLenght = random.Next(5,10);
        static void Main()
        {
            Console.SetWindowSize(80,45);

            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            for (int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    
                    var b = RandomString(randomLenght);
                    foreach (var c  in b)
                    {
                        if (c == b.ToCharArray()[0])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(c);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(c);
                        }
                    }
                    //Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }

            Console.ReadKey();
        }

        private static void WriteSecond()
        {
            
            for (int i = 0; i < 20; i++)
            {
                //Console.ForegroundColor = ConsoleColor.White;
                var newString = RandomString(randomLenght);
                foreach (var w in newString)
                {
                    if (w == newString.ToCharArray()[0])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(new string(' ', 10) + w);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(new string(' ', 10) + w);
                    }
                }
                
                //Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(100);
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
