using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace bookishApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string SqlString = "SELECT TOP (1000) [ID], [AuthorName] FROM [bookish].[dbo].[Authors]";
            var ourCustomers = (List<Author>)db.Query<Author>(SqlString);

            foreach (var Customer in ourCustomers)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\nID: " + Customer.ID.ToString());
                Console.WriteLine("Name: " + Customer.AuthorName);
                Console.WriteLine(new string('*', 20));
            }

            Console.ReadLine();
        }
    }
}
