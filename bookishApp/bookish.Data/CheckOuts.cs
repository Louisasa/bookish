using System;

namespace bookish.Data
{
    class CheckOuts
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime DueDate { get; set; }
        public bool BeenReturned { get; set; }
    }
}
