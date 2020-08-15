using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Contents
    {
        /// <summary>
        /// Display content
        /// </summary>
        public string Content { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
    }
}
