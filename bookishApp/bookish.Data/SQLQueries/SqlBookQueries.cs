using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bookish.Data.Interfaces;
using Dapper;

namespace bookish.Data.SQLQueries
{
    public class SqlBookQueries : IBookQueries
    {
        private readonly string connectionString;

        public SqlBookQueries(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Book> GetBooksByName(string name)
        {
            using (var db = new SqlConnection(connectionString))
            {
                string sqlString = "SELECT Id, BookName, ISBN, BookCopies FROM [bookish].[dbo].[Books] where BookName = @bookName";
                return (List<Book>)db.Query<Book>(sqlString, new { bookName = name });
            }
        }

        public List<Book> GetAllBooks()
        {
            using (var db = new SqlConnection(connectionString))
            {
                string sqlString = "SELECT Id, BookName, ISBN, BookCopies FROM [bookish].[dbo].[Books]";
                return (List<Book>)db.Query<Book>(sqlString);
            }
        }
        public List<BooksAuthors> GetBooksByAuthorName(string name)
        {
            using (var db = new SqlConnection(connectionString))
            {
                //string sqlString = "SELECT Id, AuthorName FROM [bookish].[dbo].[Authors] WHERE AuthorName = @authorName";
                //db.Query<Author>(sqlString , new { authorName = name});
                string searchString =
                    "SELECT AuthorName, BookId FROM [bookish].[dbo].[Authors] a INNER JOIN [bookish].[dbo].[BooksAuthors] ba ON a.AuthorId = ba.AuthorId WHERE a.AuthorName = @authorBane";
                string searchone = "SELECT BookName, AuthorName FROM table1 INNER JOIN [bookish].[dbo].[BooksAuthors]";

                return (List<BooksAuthors>)db.Query<Book>(searchString, new { authorName = name });
            }
        }

        public int AddNewBook(Book name)
        {
            throw new System.NotImplementedException();
        }
    }
}
