using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog_Dapper.Screens.UserRoleScreen
{
    public class ListUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List UserRole");
            Console.WriteLine("=======================");
            List();
        }

        public static void List()
        {
            var repository = new UserRepository(Database.Connection); ;
            var users = repository.GetWithRoles();

            foreach(var user in users)
            {
                Console.Write($"{user.Name} - {user.Email} - ");
                foreach (var item in user.Roles)
                {
                    Console.Write($"({item.Name})");
                }
                Console.WriteLine();
            }
        }      
    }
}
