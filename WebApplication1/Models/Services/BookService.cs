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
        public void Add(Book book)
        {
            ContextDataFake.books.Add(book);
        }

        // R
        public Book FindById(int id)
        {
            return ContextDataFake.books.FirstOrDefault(book => book.Id == id);
        }

        public List<Book> FindAll()
        {
            var books = ContextDataFake.books;

            return books.OrderBy(b => b.Title).ToList();
        }

        // U
        public void Update(Book book)
        {
            var old_book = FindById(book.Id);

            old_book.Title = book.Title;
            old_book.Author = book.Author;
        }

        // D
        public void DeleteById(int id)
        {
            var book = FindById(id);
            ContextDataFake.books.Remove(book);
        }
    }
}
