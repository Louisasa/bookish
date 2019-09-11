using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace bookishApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string SqlString = "SELECT TOP 100 [CustomerID],[CustomerFirstName],[CustomerLastName],[IsActive] FROM [Customer]";
            var ourCustomers = (List<Book>)db.Query<Book>(SqlString);

        }
    }
}
