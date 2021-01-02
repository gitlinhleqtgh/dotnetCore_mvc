using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ManagementBook.Models;

namespace ManagementBook.Services 
{
    public class BookService : IBookService {
        private readonly DataContext _context;
        public BookService (DataContext context) {
            _context = context;
        }

        public Book AddNewBook(Book bookInput)
        {
            _context.Add(bookInput);
            _context.SaveChanges();
            return bookInput;
        }
        public bool DeleteBook(int Id)
        {
            var book = GetBookById(Id);
            _context.Remove(book);
            _context.SaveChanges();
            return true;
        }


        public Book GetBookById(int bookId)
        {
            return _context.Books.FirstOrDefault(b => b.Id == bookId);
        }

        public List<Book> GetBooks()
        {   
            return _context.Books.ToList();
        }


        public Book UpdateBook(Book bookInput)
        {
            var book = GetBookById(bookInput.Id);
            book.Name = bookInput.Name;
            book.Description = bookInput.Description;
            book.TotalPage = bookInput.TotalPage;
            book.ImagePath = bookInput.ImagePath;
            book.Price = bookInput.Price;
            _context.SaveChanges();
            return book;
        }


        Book IBookService.DetailBook(int Id)
        {
            var book = GetBookById(Id);
            return book;
        }

    }
}