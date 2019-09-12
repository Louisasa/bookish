using System.Web.Mvc;

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
            ViewBag.data = bookish.Data.Queries.QueryBooks("*", "", "ORDER BY [BookName] ASC");

            return View();
        }
    }
}