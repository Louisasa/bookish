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
        public static IBookQueries SetConnectionString()
        {
            return new SqlBookQueries(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
        }
    }
}
