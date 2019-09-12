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
    class SqlUserQueries : IUserQueries
    {
        private readonly string connectionString;

        public SqlUserQueries(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Users> GetBookIdByUserID(string name)
        {
            using (var db = new SqlConnection(connectionString))
            {
                string sqlString = "SELECT bookid, DueDate FROM dbo.Users where u.id = @userid";
                return  db.Query<Users>(sqlString, new { userid = name }).ToList();
            }
        }

        public List<Users> GetUserIDByLogin(string name)
        {
            throw new System.NotImplementedException();
        }
        public List<Users> GetUsernameByBook(string name)
        {
            throw new System.NotImplementedException();
        }
        public int AddNewUser(Users name)
        {
            throw new System.NotImplementedException();
        }
    }
}
