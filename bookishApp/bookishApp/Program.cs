using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using bookish.Data;
using bookish.Data.SQLQueries;

namespace bookishApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sqlBookQuery = Queries.SetConnectionStringForBooks();
            var works = sqlBookQuery.GetBooksByAuthorName("Phillip");
            

        }
    }
}
