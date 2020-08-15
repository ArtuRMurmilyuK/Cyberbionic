using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Book
{
    class Book
    {
        //First init
        static Title _title;
        static Author _author;
        static Contents _content;

        public Book(Title title, Author author, Contents content)
        {
            _title = title;
            _author = author;
            _content = content;
        }
        /// <summary>
        /// it`s book.Show(Display title, author and content)
        /// </summary>
        public static void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }
    }
}
