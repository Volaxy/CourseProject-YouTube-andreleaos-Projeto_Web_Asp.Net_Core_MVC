using System;
using System.Collections.Generic;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public static class ContextDataFake
    {
        public static List<Book> books;

        static ContextDataFake()
        {
            books = new List<Book>();
            
            InitializeData();
        }

        private static void InitializeData()
        {
            var book1 = new Book(1, "Narnia", "Editora Books");
            var book2 = new Book(2, "Web", "WWW");
            var book3 = new Book(3, "Java", "Oracle");
            var book4 = new Book(4, "Python", "Snake");

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
        }
    }
}
