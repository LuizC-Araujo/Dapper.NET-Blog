using System;

using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

using Blog_Dapper.Models;
using Blog_Dapper.Repositories;

namespace Blog_Dapper
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            //ReadUser();
            //CreateUser(connection);
            //CreateRole(connection);
            CreateTag(connection);
            ReadUsers(connection);
            ReadRoles(connection);
            ReadTags(connection);
            //UpdateUser();
            //DeleteUser();

            connection.Close();

        }

        
        public static void ReadUser()
        {
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                Console.WriteLine(user.Name);
                
            }
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var items = repository.Get();

            foreach(var item in items)
                Console.WriteLine(item.Name);
        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }

        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }

        public static void CreateUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = new User()
            {
                Bio = "John Doe bio",
                Email = "john@john.com",
                Image = "https://....",
                Name = "John Doe",
                PasswordHash = "HASH",
                Slug = "john-doe"
            };

            repository.Create(user);
            Console.WriteLine("Cadastro realizado com sucesso!");

        }

        public static void CreateRole(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var role = new Role()
            {
                Name = "Aministrador",
                Slug = "admin"
            };

            repository.Create(role);
            Console.WriteLine("Cadastro de role realizado com sucesso!");
        }

        public static void CreateTag(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var role = new Role()
            {
                Name = "C#",
                Slug = "c-sharp"
            };

            repository.Create(role);
            Console.WriteLine("Cadastro de tag realizado com sucesso!");
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
