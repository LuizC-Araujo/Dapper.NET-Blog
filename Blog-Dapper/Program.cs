using System;

using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

using Blog_Dapper.Models;

namespace Blog_Dapper
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
        static void Main(string[] args)
        {

            //ReadUser();
            //CreateUser();
            //ReadUsers();
            //UpdateUser();
            //DeleteUser();
        }

        
        public static void ReadUser()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                Console.WriteLine(user.Name);
                
            }
        }

        public static void CreateUser()
        {
            var user = new User()
            {
                Bio = "John Doe bio",
                Email = "john@john.com",
                Image = "https://....",
                Name = "John Doe",
                PasswordHash = "HASH",
                Slug = "john-doe"
            };
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastro realizado com sucesso!");

            }
        }

        public static void UpdateUser()
        {
            var user = new User()
            {
                Id = 1,
                Name = "Luiz Araujo",
                Bio = "programming",
                Email = "luiz@luiz.com",
                Image = "https://....",
                PasswordHash = "HASH",
                Slug = "luiz-araujo"
            };
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
                Console.WriteLine("Atualização realizado com sucesso!");

            }
        }

        public static void DeleteUser()
        {
           using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(2);
                connection.Delete<User>(user);
                Console.WriteLine("Exclusão realizado com sucesso!");

            }
        }
    }
}
