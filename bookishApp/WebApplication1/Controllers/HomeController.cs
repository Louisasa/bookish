using System.Web.Mvc;
using bookish.Data;

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

        public ActionResult Catalogue()
        {
            //todo: add author
            var queries = Queries.SetConnectionStringForBooks();

            var books = queries.GetAllBooks();

            return View(books);
        }
    }
}