using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookish.Data
{
    public class AuthorsWorks
    {
        public string AuthorName { get; set; }
        public List<Book> Books { get; set; }

    }
}
