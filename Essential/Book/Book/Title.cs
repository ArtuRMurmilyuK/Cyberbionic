using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Title
    {
        /// <summary>
        /// Display title
        /// </summary>
    public string Content { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
    }
}
