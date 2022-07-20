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

            StartMenu.Load();

            Console.ReadKey();
            Database.Connection.Close();

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
            var repository = new Repository<Tag>(connection);
            var tag = new Tag()
            {
                Name = "C#",
                Slug = "c-sharp"
            };

            repository.Create(tag);
            Console.WriteLine("Cadastro de tag realizado com sucesso!");
        }

        public static void UpdateUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = new User()
            {
                Id = 1,
                Name = "Luiz Araujo Silva",
                Bio = "programming-2",
                Email = "luiz@luiz.com",
                Image = "https://....",
                PasswordHash = "HASH",
                Slug = "luiz-araujo"
            };

            repository.Update(user);
            Console.WriteLine("Atualização realizado com sucesso!");
        }

        public static void UpdateRole(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var role = new Role()
            {
                Id = 2,
                Name = "Administrator",
                Slug = "administrator"
            };

            repository.Update(role);
            Console.WriteLine("Atualização de role realizado com sucesso!");
        }

        public static void UpdateTag(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var tag = new Tag()
            {
                Id = 2,
                Name = "C-Sharp",
                Slug = "c-sharp"
            };

            repository.Update(tag);
            Console.WriteLine("Atualização de tag realizado com sucesso!");
        }

        public static void DeleteUser(SqlConnection connection, int id)
        {
            var repository = new Repository<User>(connection);
            var user = repository.Get(id);
            if(user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }

            repository.Delete(user);
            Console.WriteLine("Exclusão realizado com sucesso!");
        }

        public static void DeleteRole(SqlConnection connection, int id)
        {
            var repository = new Repository<Role>(connection);
            var role = repository.Get(id);
            if (role == null)
            {
                Console.WriteLine("Role not found!");
                return;
            }

            repository.Delete(role);
            Console.WriteLine("Exclusão de role realizado com sucesso!");
        }

        public static void DeleteTag(SqlConnection connection, int id)
        {
            var repository = new Repository<Tag>(connection);
            var tag = repository.Get(id);
            if (tag == null)
            {
                Console.WriteLine("Tag not found!");
                return;
            }

            repository.Delete(tag);
            Console.WriteLine("Exclusão de role realizado com sucesso!");
        }

        public static void ReadUsersWithRoles(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var items = repository.GetWithRoles();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($" - {role.Name}");
                }
            }
        }
    }
}
