using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 25)
                    cheapBooks.Add(book);
            }
      
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }

            //var anonymsInstance = new { Title = "title" };
            //anonymsInstance.Title
            #region Syntax
            // Linq Query operators
            var values = from b in books
                         where b.Price < 25
                         orderby b.Title
                         select b.Title;

            // Linq Extension Methods
            var filteredValues = books
                .Where(b => b.Price < 25)
                .OrderBy(b => b.Title)
                .Select(b => new { b.Title, b.Price });
            foreach (var item in filteredValues)
            {
                Console.WriteLine(item.Title);
            }
            #endregion
        }
    }
}
