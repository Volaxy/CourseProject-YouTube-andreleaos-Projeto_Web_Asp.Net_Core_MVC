using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models.Contracts;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Models.Services
{
    public class BookService : IBookService
    {
        public List<Book> GetAll()
        {
            var books = ContextDataFake.books;

            return books.OrderBy(b => b.Title).ToList();
        }
    }
}
