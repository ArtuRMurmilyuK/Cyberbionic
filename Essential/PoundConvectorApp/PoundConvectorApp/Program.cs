namespace PoundConvectorApp
{
    class Program
    {
        static void Main()
        {
            var conv = new Convector();

            var console = new ConsoleWrapper();
            console.WriteLine(conv.NewPound(7, 22, 9).Pennies);
        }
    }
}
