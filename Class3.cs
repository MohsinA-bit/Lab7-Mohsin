using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_M.Ali
{
    class BookTest
    {
        public static void Main(string[] args)
        {
            Author name = new authorName("Jane Austen");
            Title title = new bookTitle("Pride and Prejudice");
            Publish year = new Date(1, 28, 1813);
            Book information = new Book("Pride and Prejudice", "Jane Austen", year);

            Console.WriteLine(information);
        }
    }
}

    

