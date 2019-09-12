using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookish.web.Models
{
    public class BookInfoModel
    {
        public string BookName { get; set; }
        public int BookCopies { get; set; }
        public List<CheckoutViewModel> Checkouts { get; set; }
    }

    public class CheckoutViewModel
    {
        public DateTime DueDate { get; set; }
        public string UserName { get; set; }

        public override string ToString()
        {
            return "Checked out by user: " + this.UserName + " - Due Back: " + this.DueDate.ToShortDateString();
        }
    }
}