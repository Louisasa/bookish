using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookish.Data;
using bookish.Data.Interfaces;
using bookish.web.Models;

namespace bookish.web.Controllers
{
    public class BookController : Controller
    {
        public ActionResult BookInfoPage(string id)
        {
            if (id != null)
            {
                ViewBag.Message = "Book stuff";
                var bookQueries = Queries.SetConnectionStringForBooks();
                var checkOutQueries = Queries.SetConnectionStringForCheckOuts();

                var bookInfo = bookQueries.GetBooksByName(id).SingleOrDefault();
                var checkOutInfo = checkOutQueries.GetCheckOutsByBookID(bookInfo.ID);

                var bookInfoModel = new BookInfoModel
                {
                    BookName = bookInfo.BookName,
                    BookCopies = bookInfo.BookCopies,
                    Checkouts = checkOutInfo.Select(c => new CheckoutViewModel
                        {UserName = c.UserName, DueDate = c.DueDate}).ToList()
                };
                return View(bookInfoModel);
            }
            else
            {
                return View(new BookInfoModel());
            }


        }
    }
}