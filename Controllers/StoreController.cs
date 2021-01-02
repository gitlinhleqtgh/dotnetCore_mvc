using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagementBook.Models;
using ManagementBook.Services;

namespace ManagementBook.Controllers
{
    public class StoreController:Controller
    {
         private readonly IBookService _bookService;
         public StoreController(IBookService bookService)
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
    }
    
}