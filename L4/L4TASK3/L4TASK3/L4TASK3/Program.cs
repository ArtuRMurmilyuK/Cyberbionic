using System;



namespace L4TASK3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select word for translate: Дождь, Снег, Солнце, Облачно, Град, Шторм, Потоп, Безоблачный, Ветер, Гололёд");
            var words = Console.ReadLine();
            string result = null;
            switch (words)
            {
                case "Дождь":
                {
                    result = "Rain";
                    break;
                }
                case "Снег":
                {
                    result = "Snow";
                    break;
                }
                case "Солнце":
                {
                    result = "The sun";
                    break;
                }
                case "Облачно":
                {
                    result = "Cloudy";
                    break;
                }
                case "Град":
                {
                    result = "Hail";
                    break;
                }
                case "Шторм":
                {
                    result = "Storm";
                    break;
                }
                case "Потоп":
                {
                    result = "Deluge";
                    break;
                }
                case "Безоблачный":
                {
                    result = "Cloudless";
                    break;
                }
                case "Ветер":
                {
                    result = "Wind";
                    break;
                }
                case "Гололёд":
                {
                    result = "Ice";
                    break;
                }
                    
                default:
                {
                    Console.WriteLine("This word is not in the dictionary.");
                    Console.ReadKey();
                    break;
                }

            }
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
