using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace bookish.DataAccess
{
    class Queries
    {
        public static IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public static List<Book> QueryBooks(string selectStatement, string whereStatement, string orderByStatement)
        {
            string sqlString = "SELECT " + selectStatement + " FROM [bookish].[dbo].[Books] " + whereStatement +
                               orderByStatement;
            return (List<Book>)db.Query<Book>(sqlString);
        }
    }
}
