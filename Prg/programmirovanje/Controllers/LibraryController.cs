using programmirovanje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace programmirovanje.Controllers
{
    public class LibraryController : Controller
    {
        private IBookRepository repository;

        public LibraryController(IBookRepository repo)
        {
            repository = repo;
        }

        public RedirectToRouteResult AddToLibrary(int bookId)
        {
            Book book = repository.Books
                .FirstOrDefault(b => b.BookId == bookId);

            if (book != null)
            {
                GetLibrary().AddItem(book);
            }
            return RedirectToAction("Index");
        }
        public ViewResult Index()
        {
            return View(new LibraryIndexViewModel
            {
                Library = GetLibrary()
            }) ;
        }
        public RedirectToRouteResult RemoveFromLibrary(int bookId)
        {
            Book book = repository.Books
                .First(g => g.BookId == bookId);

            if (book != null)
            {
                GetLibrary().RemoveLine(book);
            }
            return RedirectToAction("Index");
        }
        public Library GetLibrary()
        {
            Library library = (Library)Session["Library"];
            if (library == null)
            {
                library = new Library();
                Session["Library"] = library;
            }
            return library;
        }
    }
}