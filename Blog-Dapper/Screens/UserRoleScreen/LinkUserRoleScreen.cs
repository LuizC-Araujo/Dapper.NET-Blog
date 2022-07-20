using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using Blog_Dapper.Shared;
using Dapper;
using System;

namespace Blog_Dapper.Screens.UserRoleScreen
{
    public class LinkUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Link User to Profile");
            Console.WriteLine("========================");
            Console.WriteLine("Choose an User id: ");
            var userId = Choose.ChooseId();
            Console.WriteLine("Choose a Profile id: ");
            var roleId = Choose.ChooseId();

            Link(new UserRole
            {
                UserId = userId,
                RoleId = roleId
            });

            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }

        public static void Link(UserRole user)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário linkado ao Profile com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível linkar o usuário ao profile!");
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
