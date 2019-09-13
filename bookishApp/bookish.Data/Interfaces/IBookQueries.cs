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
        List<Book> GetBooksById(int name);
        List<Book> GetAllBooks();
        AuthorsWorks GetBooksByAuthorName(string name);
        int AddNewBook(Book name);
        AuthorsWorks GetAuthorByBookName(string searchSearchString);
    }
}
