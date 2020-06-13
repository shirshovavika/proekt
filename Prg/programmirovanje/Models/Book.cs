using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace programmirovanje.Models
{
    public class Book
    {
        //ID книги
        [HiddenInput(DisplayValue = false)]
        public int BookId { get; set; }
        //название книги
        public string Name { get; set; }
        //автор книги
        public string Author { get; set; }
        //цена
        public string Description { get; set; }
        public string Category { get; set; }

        public int Price { get; set; }
    }
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }
    }
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public string CurrentCategory { get; set; }
    }
}