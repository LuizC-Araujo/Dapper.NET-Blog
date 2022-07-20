using System;

using Blog_Dapper.Models;
using Blog_Dapper.Repositories;

namespace Blog_Dapper.Screens.UserScreen
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("User Update");
            Console.WriteLine("=================");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
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

            Update(new User
            {
                Id = int.Parse(id),
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

        private static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Usuário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar o usuároio!");
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
