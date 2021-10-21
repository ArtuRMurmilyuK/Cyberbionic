using System;
using System.Linq.Expressions;

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
            var analiz = new TableManager();
            analiz.Analyzation(_content);

            Console.Clear();
            // ╔
            Console.Write($"{(char)9556}");
            // ═ (1 - ║ и ╔, ╗ )(два символа сверху и один слева)
            for (int i = 0; i <= (_tabParams.Width + 1) * _tabParams.Height - 2; i++)
            {
                Console.Write($"{(char)9552}");
            }
            // ╗
            Console.WriteLine($"{(char)9559}");

            for (int j = 0; j < 10; j++)
            {
                // ║
                Console.Write($"{(char)9553}");

                for (int i = 0; i < _tabParams.Height; i++)
                {
                    Console.Write(_content[i][j]);

                    if (i < _tabParams.Height - 1)
                    {
                        Console.Write($"{(char)9553}");
                    }
                }

                Console.WriteLine($"{(char)9553}");
            }
            // ╚
            Console.Write($"{(char)9562}");
            // ═ (2 - ║ и ╔, ╗)
            for (int i = 0; i <= (_tabParams.Width + 1) * _tabParams.Height - 2; i++)
            {
                Console.Write($"{(char)9552}");
            }
            // ╝
            Console.Write($"{(char)9565}");
        }
    }
}