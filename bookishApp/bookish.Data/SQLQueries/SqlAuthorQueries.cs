
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using bookish.Data.Interfaces;
using Dapper;

namespace bookish.Data.SQLQueries
{
    class SqlAuthorQueries : IAuthorQueries
    {
        private readonly string connectionString;

        /* public static List<BooksAuthors> QueryAuthor(string selectStatement, string whereStatement, string orderByStatement)
        {
            using (var db =
                new SqlConnection(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString))
            {
                string sqlString = "SELECT " + selectStatement + " FROM [bookish].[dbo].[Books-Authors] " + whereStatement +
                                   orderByStatement;
                return (List<BooksAuthors>)db.Query<BooksAuthors>(sqlString);
            }
        }*/
        public SqlAuthorQueries(string connectionString)
        {
            this.connectionString = connectionString;
        }

    }
}
