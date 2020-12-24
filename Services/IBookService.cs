using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementBook.Models;

namespace ManagementBook.Services
{
    public interface IBookService
    {
       public List<Book> GetBooks();
       public Book GetBookById(int bookId);
       public Book AddNewBook(Book bookInput);
       public Book UpdateBook(Book bookInput);
       public bool DeleteBook(int id); 
       public Book DetailBook(int id);
    }
}