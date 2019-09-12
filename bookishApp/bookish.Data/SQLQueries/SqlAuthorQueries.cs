using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bookish.Data.Interfaces;

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

        public List<BooksAuthors> GetAuthorIDByBookName(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<Author> GetAuthorNameByAuthorID(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
