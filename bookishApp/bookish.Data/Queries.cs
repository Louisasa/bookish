using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using bookish.Data.Interfaces;
using bookish.Data.SQLQueries;
using Dapper;

namespace bookish.Data
{
    public static class Queries
    {
        public static IBookQueries GetBookQueries()
        {
            return new SqlBookQueries(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
        }

        public static List<BooksAuthors> QueryAuthor(string selectStatement, string whereStatement, string orderByStatement)
        {
            using (var db =
                new SqlConnection(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString))
            {
                string sqlString = "SELECT " + selectStatement + " FROM [bookish].[dbo].[Books-Authors] " + whereStatement +
                                   orderByStatement;
                return (List<BooksAuthors>)db.Query<BooksAuthors>(sqlString);
            }
        }
    }
}
