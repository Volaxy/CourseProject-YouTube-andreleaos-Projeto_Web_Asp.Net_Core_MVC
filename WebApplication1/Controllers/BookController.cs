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
            return View(bookService.FindAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            bookService.Add(book);

            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            if (isInvalid(id))
                return NotFound();

            return View(bookService.FindById(id));
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            bookService.Update(book);

            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            var book = bookService.FindById(id);

            return View(book);
        }

        public IActionResult Delete(int id)
        {
            if (isInvalid(id))
                return NotFound();

            return View(bookService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            bookService.DeleteById(book.Id);

            return RedirectToAction("List");
        }

        private bool isInvalid(int id)
            {
                return string.IsNullOrEmpty(id.ToString())
                    || bookService.FindById(id) == null;
            }
    }
}
