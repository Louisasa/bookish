using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bookish.Data;

namespace bookish.web.Models
{
    public class AuthorWorksInfo
    {
        public List<Author> Authors{ get; set; }
        public List<Book> Books { get; set; }
    }

}