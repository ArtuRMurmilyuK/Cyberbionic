using System;

namespace Book
{
    class Program
    {
        /// <summary>
        /// Display Name book, author, content 
        /// </summary>
        static void Main()
        {
            Title title = new Title();
            title.Content = Console.ReadLine();

            Author author = new Author();
            author.Content = Console.ReadLine();

            Contents content = new Contents();
            content.Content = Console.ReadLine();

            Book book = new Book(title, author, content);
            Book.Show();
        }
    }
}
