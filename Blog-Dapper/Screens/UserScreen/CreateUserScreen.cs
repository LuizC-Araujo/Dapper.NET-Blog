using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using System;

namespace Blog_Dapper.Screens.UserScreen
{
    public class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("User Create");
            Console.WriteLine("=================");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Bio: ");
            var bio = Console.ReadLine();
            Console.WriteLine("Imagem: ");
            var image = Console.ReadLine();
            Console.WriteLine("Senha: ");
            var password = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                Bio = bio,
                Image = image,
                PasswordHash = password,
                Slug = slug
            });

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário cadastrado com sucesso!");
            }catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar o usuário!");
                Console.WriteLine($"Erro: {ex.Message}");
            }
            

        }
    }
}
