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
            _content = content;
        }

        public void Build()
        {
            Console.Clear();

            var analiz = new TableManager();
            analiz.Analyzation(_content);

            // ╔
            Console.Write($"{(char)9556}");

            // ═
            for (int i = 0; i <= _tabParams.Width; i++)
            {
                Console.Write($"{(char)9552}");
            }

            // ╗
            Console.WriteLine($"{(char)9559}");

            // ║
            //Console.Write($"{(char)9553}");

            //если нет контента то пустая строка
            if (_content == null)
            {
                for (int j = 0; j <= _tabParams.Width; j++)
                {
                    Console.Write(" ");
                }
            }
            else
            {
                for (int j = 0; j < 10; j++)
                {
                    // ║
                    Console.Write($"{(char)9553}");
                    Console.Write(_content[0][j]);
                    Console.WriteLine($"{(char)9553}");
                }
            }
                // ╚
            Console.Write($"{(char)9562}");

            // ═
            for (int i = 0; i <= _tabParams.Width; i++)
            {
                Console.Write($"{(char)9552}");
            }

            // ╝
            Console.Write($"{(char)9565}");
        }
    }
}