using System;

using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using Blog_Dapper.Screens;

namespace Blog_Dapper
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            StartMenuScreen.Load();

            Console.ReadKey();
            Database.Connection.Close();
        }
    }
}
