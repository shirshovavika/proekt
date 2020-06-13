using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    class Book
    {
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
}
