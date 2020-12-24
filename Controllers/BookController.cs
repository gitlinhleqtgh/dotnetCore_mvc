using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagementBook.Models;
using ManagementBook.Services;

namespace ManagementBook.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            List<Book> books = _bookService.GetBooks();
            
            // ViewData["BookKey"] = books;
            //ViewBag.Books = books;
            return View(books);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult SaveBook(Book book)
        {
            if(book.Id == 0)
            {
                _bookService.AddNewBook(book);
            }
            _bookService.UpdateBook(book);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            var book = _bookService.GetBookById(Id);
            return View(book);
        }
        public IActionResult Delete(int Id)
        {
            _bookService.DeleteBook(Id);
            return RedirectToAction("Index"); 
        }
        public IActionResult Detail(int Id)
        {
            var book = _bookService.GetBookById(Id);
            return View(book);

        }
    }

}