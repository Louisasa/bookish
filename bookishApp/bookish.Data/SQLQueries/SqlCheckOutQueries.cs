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

        public List<CheckOuts> GetCheckOutsByBookID(int name)
        {
            using (var db = new SqlConnection(connectionString))
            {
                string sqlString = "SELECT * FROM dbo.CheckOuts WHERE[BookID] = @id AND [BeenReturned] = 0; ";
                return (List<CheckOuts>)db.Query<CheckOuts>(sqlString, new { id = name });
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
