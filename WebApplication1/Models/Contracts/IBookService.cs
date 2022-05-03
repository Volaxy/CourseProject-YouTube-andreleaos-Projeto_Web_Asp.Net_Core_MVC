using System.Collections.Generic;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Contracts
{
    public interface IBookService
    {
        public List<Book> GetAll();
    }
}
