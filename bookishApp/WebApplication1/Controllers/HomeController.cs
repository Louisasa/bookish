using System.Collections.Generic;
using System.Web.Mvc;
using bookish.Data;
using bookish.web.Models;
namespace bookish.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Search(Search search)
        {
            var queries = Queries.SetConnectionStringForBooks();
            var authorWorks = queries.GetBooksByAuthorName(search.searchString);
            if (authorWorks.Books.Count != 0)
            {
                var authorworksInfo = new AuthorWorksInfo
                {
                    Authors = authorWorks.Authors,
                    Books = authorWorks.Books
                };
                return View(authorworksInfo);
            }
            else
            {
                var books = queries.GetAuthorByBookName(search.searchString);
                var authorworksInfo = new AuthorWorksInfo()
                {
                    Authors = books.Authors,
                    Books = books.Books
                };
                return View(authorworksInfo);
            }
        }

        public ActionResult Catalogue()
        {
            //todo: add author
            var queries = Queries.SetConnectionStringForBooks();

            var books = queries.GetAllBooks();

            return View(books);
        }
    }

    public class Search
    {
        public string searchString { get; set; }
    }
}