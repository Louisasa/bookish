using System;

namespace bookish.Data
{
    public class CheckOutsBooks
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime DueDate { get; set; }
        public bool BeenReturned { get; set; }
        public string UserName { get; set; }
        public string BookName { get; set; }
        public int BookCopies { get; set; }
    }
}
