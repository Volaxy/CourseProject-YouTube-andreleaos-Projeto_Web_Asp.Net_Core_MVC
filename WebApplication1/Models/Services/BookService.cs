using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models.Contracts;
using WebApplication1.Models.Db;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Services
{
    public class BookService : IBookService
    {
        // C
        public void AddBook(Book book)
        {
            ContextDataFake.books.Add(book);
        }

        // R
        public List<Book> GetAll()
        {
            var books = ContextDataFake.books;

            return books.OrderBy(b => b.Title).ToList();
        }
    }
}
