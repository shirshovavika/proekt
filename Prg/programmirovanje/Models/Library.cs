using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace programmirovanje.Models
{
    public class Library
    {
        private List<LibraryLine> lineCollection = new List<LibraryLine>();

        public void AddItem(Book book)
        {
            LibraryLine line = lineCollection
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();
            lineCollection.Add(new LibraryLine
            {
                Book = book
            });
        }

        public void RemoveLine(Book book)
        {
            lineCollection.RemoveAll(l => l.Book.BookId == book.BookId);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<LibraryLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class LibraryLine
    {
        public Book Book { get; set; }
    }
    public class LibraryIndexViewModel
    {
        public Library Library { get; set; }
    }
}