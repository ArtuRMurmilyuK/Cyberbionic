using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Author
    {
        /// <summary>
        /// Display Author
        /// </summary>
        public string Content { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
