using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Contracts;
using WebApplication1.Models.Services;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService = new BookService();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(bookService.GetAll());
        }
    }
}
