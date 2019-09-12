using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace bookish.Data
{
    public class Queries
    {

        public static List<Book> QueryBooks(string selectStatement, string whereStatement, string orderByStatement)
        {
            using (var db =
                new SqlConnection(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString))
            {
                string sqlString = "SELECT " + selectStatement + " FROM [bookish].[dbo].[Books] " + whereStatement +
                                   orderByStatement;
                return (List<Book>) db.Query<Book>(sqlString);
            }
        }
    }
}
