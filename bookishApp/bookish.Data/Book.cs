﻿namespace bookish.Data
{
    public class Book
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public int BookCopies { get; set; }

        public override string ToString()
        {
            return this.ID + " " + this.BookName + " " + this.ISBN + " " + this.BookCopies;
        }
    }
}
