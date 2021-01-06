using System;

namespace TrainInfo
{
    class AllAboutTrain
    {
        public static void Sort(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].Number <= trains[j].Number)
                    {
                        Train x = trains[i];
                        trains[i] = trains[j];
                        trains[j] = x;
                    }
                }
            }
        }

        public static void Search(Train[] train, int poisk)
        {
            bool check = false;
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].Number == poisk)
                {
                    Console.WriteLine("Номер поезда: {0} Пункт назначения: {1} Дата и время отправки: {2} ", 
                        train[i].Number, train[i].Destination, train[i].Time);

                    check = true;
                }
            }

            if (!check)
            {
                Console.WriteLine("Поезд не найден");
            }
        }

        public static void AddInArray(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Введите пункт назначения поезда: ");
                string destination = Console.ReadLine();
                destination = string.IsNullOrEmpty(destination) ? "Не указан пункт назначения" : destination;

                Console.Write("Введите номер поезда: ");
                string enterValue = Console.ReadLine();
                int number = string.IsNullOrEmpty(enterValue) ? 0 : Convert.ToInt32(enterValue);

                Console.Write("Введите дату отправки: ");
                enterValue = Console.ReadLine();
                DateTime date = string.IsNullOrEmpty(enterValue) ? DateTime.Now : DateTime.Parse(enterValue);

                trains[i] = new Train(destination, number, date);
            }
        }

        public static void Show(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Номер поезда: {0} Пункт назначения: {1} Дата и время отправления: {2} ", trains[i].Number,
                    trains[i].Destination, trains[i].Time);
            }
        }
    }
}
