using System;

namespace TrainInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = new Train[3];

            AllAboutTrain.AddInArray(train);
            Console.WriteLine(new string('-',50));

            Console.WriteLine("You are enter this information:");
            Console.WriteLine(new string('-',50 ));

            AllAboutTrain.Sort(train);
            AllAboutTrain.Show(train);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Enter number of train:");
            int poisk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 50));
            AllAboutTrain.Search(train, poisk);
        }
    }
}
