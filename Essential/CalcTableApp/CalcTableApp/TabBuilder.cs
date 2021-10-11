using System;

namespace CalcTableApp
{
    internal class TabBuilder
    {
        private readonly TabParams _tabParams;
        private readonly string[][] _content;

        public TabBuilder(TabParams tabParams, string[][] content)
        {
            _tabParams = tabParams;
            _content = null;
        }

        public void Build()
        {
            Console.Clear();

            // ╔
            Console.Write($"{(char)9556}");

            // ═
            for (int i = 0; i <= 12; i++)
            {
                Console.Write($"{(char)9552}");
            }

            // ╗
            Console.WriteLine($"{(char)9559}");

            for (int i = 0; i <= 12; i++)
            {
                // ║
                Console.Write($"{(char)9553}");

                //если нет контента то пустая строка
                if (_content == null)
                {
                    for (int j = 0; j <= 12; j++)
                    {
                        Console.Write(" ");
                    }
                }

                // ║
                Console.WriteLine($"{(char)9553}");
            }

            // ╚
            Console.Write($"{(char)9562}");

            // ═
            for (int i = 0; i <= 12; i++)
            {
                Console.Write($"{(char)9552}");
            }

            // ╝
            Console.Write($"{(char)9565}");
        }
    }
}