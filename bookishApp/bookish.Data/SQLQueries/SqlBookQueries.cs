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

        public int AddNewBook(Book name)
        {
            throw new System.NotImplementedException();
        }
    }
}
