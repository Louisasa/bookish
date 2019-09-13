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

        public int GetUserIDByEmail(string name)
        {
            using (var db = new SqlConnection(connectionString))
            {
                string sqlString = "SELECT id FROM dbo.Users where Email = @email";
                return db.Query<int>(sqlString, new { email = name }).SingleOrDefault();
            }
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
