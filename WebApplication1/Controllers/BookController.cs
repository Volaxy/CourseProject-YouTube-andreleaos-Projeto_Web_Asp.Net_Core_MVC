using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Contracts;
using WebApplication1.Models.Entities;
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

        public IActionResult Create()
        {
            return View();
        }

        // The "HttpPost" informs which this method only is called when for example, the submit button of a form is clicked
        [HttpPost]
        public IActionResult Create(Book book)
        {
            bookService.AddBook(book);

            // The "RedirectToAction" call the method with the name passed by parameter
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            if(string.IsNullOrEmpty(id.ToString()))
                return NotFound();

            var book = bookService.FindById(id);
            if(book == null)
                return NotFound();

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            bookService.UpdateBook(book);

            return RedirectToAction("List");
        }
    }
}
