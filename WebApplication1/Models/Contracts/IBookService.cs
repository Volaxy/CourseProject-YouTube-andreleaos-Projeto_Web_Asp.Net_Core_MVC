using System.Collections.Generic;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Contracts
{
    public interface IBookService
    {
        // C
        void Add(Book book);

        // R
        Book FindById(int id);

        List<Book> FindAll();

        // U
        void Update(Book book);

        // D
        void DeleteById(int id);
    }
}
