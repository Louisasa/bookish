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
        public static IBookQueries SetConnectionStringForBooks()
        {
            return new SqlBookQueries(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
        }

        public static ICheckOutQueries SetConnectionStringForCheckOuts()
        {
            return new SqlCheckOutQueries(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
        }

        public static IUserQueries SetConnectionStringForUsers()
        {
            return new SqlUserQueries(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
        }
}
}
