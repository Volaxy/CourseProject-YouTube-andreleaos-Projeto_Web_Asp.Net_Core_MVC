using System.Collections.Generic;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Contracts
{
    public interface IBookService
    {
        // C
        void AddBook(Book book);

        // R
        List<Book> GetAll();
    }
}
