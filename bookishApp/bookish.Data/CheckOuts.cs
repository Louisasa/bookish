using System;

namespace bookish.Data
{
    public class CheckOuts
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime DueDate { get; set; }
        public bool BeenReturned { get; set; }

        public override string ToString()
        {
            return this.ID + " " + this.UserID + " " + this.BookID + " " + this.DueDate.ToShortDateString() + " " + this.BeenReturned;
        }
    }
}
