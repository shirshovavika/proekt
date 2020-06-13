using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace programmirovanje.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
    : base(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + HttpContext.Current.Server.MapPath("~/App_Data/Books.mdf")
            + ";Integrated Security=True")
        { }

        public DbSet<Book> Books { get; set; }
    }
    public class EFBookRepository : IBookRepository
    {
        BookContext context = new BookContext();

        public IEnumerable<Book> Books
        {
            get { return context.Books; }
        }
    }
}