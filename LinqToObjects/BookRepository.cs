using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class BookRepository
    {
        public IEnumerable<Book> GetBooks() // why use IEnumerable<> as return type instead of List<>?
        {
            return new List<Book>
            {
                new Book() {Title = "ASP.NET MVC5", Price = 1 },
                new Book() {Title = "Beginning C#", Price = 5 },
                new Book() {Title = "Intermediate C#", Price = 15 },
                new Book() {Title = "Advanced C#", Price = 7 },
                new Book() {Title = "Advanced C#", Price = 12 },
                new Book() {Title = "Web Dev in .NET", Price = 35 },
                new Book() {Title = "Intro to LINQ", Price = 45 }
            };
        }
    }
}
