using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookish.Data.Interfaces
{
    public interface IBookQueries
    {
        List<Book> GetBooksByName(string name);
        List<Book> GetAllBooks();
        int AddNewBook(Book name);
    }
}
