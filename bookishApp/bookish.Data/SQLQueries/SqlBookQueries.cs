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
                var searchOne = "SELECT AuthorName, BookId FROM [bookish].[dbo].[Authors] a INNER JOIN [bookish].[dbo].[BooksAuthors] ba ON a.AuthorId = ba.AuthorId WHERE a.AuthorName = @authorBane";
                var searchTwo = $"SELECT BookName FROM ({searchOne}) d INNER JOIN [bookish].[dbo].[Books] b ON d.BookId = ba.BookId";
                var authorWork = new AuthorsWorks
                {
                    AuthorName = name, Books = db.Query<Book>(searchOne, new {authorName = name}).ToList()
                };
                return authorWork;
            }
        }

        public int AddNewBook(Book name)
        {
            throw new System.NotImplementedException();
        }
    }
}
