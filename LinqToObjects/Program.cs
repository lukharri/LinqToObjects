using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // ***EXAMPLE*** //  
            // display books s.t. price < 10.
            // w/out LINQ it might look something like this
            /*
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);
            }

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);
            */


            // ***EXAMPLE*** // 
            // using LINQ Extension Methods
            // display books that cost less than 10
            /* var cheapBooks = books.Where(b => b.Price < 10); */

            // display books less than 10 and put them in order by title (alpha order)
            /*
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title);

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);
            */


            // ***EXAMPLE*** // 
            // w/LINQ extension methods
            // retieve books less than 10, order by title (alpha order), select titles (converts to string)

            /*
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
            */


            // ***EXAMPLE*** // 
            // w /LINQ query operators
            /*
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
            */

            // *** EXAMPLE *** //
            // more LINQ extension methods

            var book0 = books.First(b => b.Title == "Advanced C#");
            Console.WriteLine(book0.Title + " " + book0.Price + "\n");

            var book1 = books.FirstOrDefault(b => b.Title == "Advanced C#");
            Console.WriteLine(book1.Title + " " + book1.Price + "\n");

            var book2 = books.Last(b => b.Title == "Advanced C#");
            Console.WriteLine(book2.Title + " " + book2.Price + "\n");

            var book3 = books.LastOrDefault(b => b.Title == "Advanced C#");
            Console.WriteLine(book3.Title + " " + book3.Price + "\n");


            var book4 = books.Single(b => b.Title == "ASP.NET MVC5"); // throws error if no matching title
            Console.WriteLine(book4.Title + "\n");

            var book5 = books.SingleOrDefault(b => b.Title == "Beginning C$"); // returns null if no matching title
            Console.WriteLine(book5 == null);
            Console.WriteLine("\n");

            // skip and take used for paging
            var pagedBooks = books.Skip(2).Take(5);
            foreach ( var pagedBook in pagedBooks)
                Console.WriteLine(pagedBook.Title);
            Console.WriteLine("\n");

            var count = books.Count();
            Console.WriteLine("Number of books in repo: " + count + "\n");

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine("Most expensive book is: $" + maxPrice + "\n");

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine("Least expensive book is: $" + minPrice + "\n");

            var sumOfBookPrices = books.Sum(b => b.Price);
            Console.WriteLine("The sum of the book prices is: $" + sumOfBookPrices + "\n");

            var averageOfBookPrices = books.Average(b => b.Price);
            Console.WriteLine("The average book price is: $" + averageOfBookPrices + "\n");
        }
    }
}
