using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookish.Data;
using bookish.Data.Interfaces;

namespace bookish.web.Controllers
{
    public class BookController : Controller
    {
        public ActionResult BookInfoPage(string id)
        {
            ViewBag.Message = "Book stuff";
            var bookQueries = Queries.SetConnectionStringForBooks();
            var checkOutQueries = Queries.SetConnectionStringForCheckOuts();

            var bookInfo = bookQueries.GetBooksByName(id);
            var checkOutInfo = checkOutQueries.GetCheckOutsByBookID(bookInfo[0].ID);

            return View(checkOutInfo);
        }
    }
}