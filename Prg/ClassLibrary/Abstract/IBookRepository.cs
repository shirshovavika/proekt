using ClassLibrary.Entities;
using System.Collections.Generic;

namespace ClassLibrary.Abstract
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }

    }
}
