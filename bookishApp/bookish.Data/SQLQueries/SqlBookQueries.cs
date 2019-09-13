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
                return db.Query<Book>(sqlString, new { bookName = name }).ToList();
            }
        }

        public List<Book> GetBooksById(int name)
        {
            using (var db = new SqlConnection(connectionString))
            {
                string sqlString = "SELECT Id, BookName, ISBN, BookCopies FROM [bookish].[dbo].[Books] where Id = @bookName";
                return db.Query<Book>(sqlString, new { bookName = name}).ToList();
            }
        }

        public List<Book> GetAllBooks()
        {
            using (var db = new SqlConnection(connectionString))
            {
                string sqlString = "SELECT Id, BookName, ISBN, BookCopies FROM [bookish].[dbo].[Books]";
                return db.Query<Book>(sqlString).ToList();
            }
        }
        public AuthorsWorks GetBooksByAuthorName(string name)
        {
            using (var db = new SqlConnection(connectionString))
            {
                var searchOne = "SELECT AuthorName, BookId FROM [dbo].[Authors] a INNER JOIN [dbo].[Books-Authors] ba ON a.ID = ba.authorID WHERE a.AuthorName = @authorName";
                var searchTwo = $"SELECT Id, BookName, ISBN, BookCopies FROM ({searchOne}) d INNER JOIN [dbo].[Books] b ON d.BookId = b.Id";
                return new AuthorsWorks
                {
                    AuthorName = name, Books = db.Query<Book>(searchTwo, new {authorName = name}).ToList()
                };
            }
        }

        public int AddNewBook(Book name)
        {
            throw new System.NotImplementedException();
        }
    }
}
