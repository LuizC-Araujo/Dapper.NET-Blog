using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.ProfileScreen
{
    public class CreateProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Profile Create");
            Console.WriteLine("=================");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Role
            {
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuProfileScreen.Load();
        }

        private static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Create(role);
                Console.WriteLine("Profile cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar o profile!");
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
