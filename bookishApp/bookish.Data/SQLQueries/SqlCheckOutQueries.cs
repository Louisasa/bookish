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
    public class SqlCheckOutQueries : ICheckOutQueries
    {
        private readonly string connectionString;

        public SqlCheckOutQueries(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<CheckOutsBooks> GetCheckOutsByBookID(int name)
        {
            using (var db = new SqlConnection(connectionString))
            {
                string sqlString = "SELECT u.UserName, c.DueDate, b.BookCopies, b.BookName, c.ID, c.BeenReturned, c.UserID, c.BookID FROM dbo.Books b, dbo.CheckOuts c Join dbo.Users u on c.UserID = u.ID WHERE[BookID] = @id and c.BeenReturned = 0 and b.ID = c.BookID; ";
                return (List<CheckOutsBooks>)db.Query<CheckOutsBooks>(sqlString, new { id = name });
            }
        }

        public List<CheckOuts> GetCheckOutsByUserID(int name)
        {
            throw new System.NotImplementedException();
        }

        public List<CheckOuts> GetAllCheckOuts()
        {
            throw new System.NotImplementedException();
        }
    }
}
