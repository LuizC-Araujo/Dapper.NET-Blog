using System;

using Blog_Dapper.Models;
using Blog_Dapper.Repositories;

namespace Blog_Dapper.Screens.UserScreen
{
    public class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("User List");
            Console.WriteLine("=================");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - ({item.Email} - {item.Slug} - {item.Bio})");
            }
        }
    }
}
