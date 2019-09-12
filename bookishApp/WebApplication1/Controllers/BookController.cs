using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookish.Data;

namespace bookish.web.Controllers
{
    public class BookController : Controller
    {
        public ActionResult BookInfoPage(string id)
        {
            ViewBag.Message = "Book stuff";
            var queries  = Queries.GetBookQueries();
            //queries.GetBooksByName();

            return View();
        }
    }
}