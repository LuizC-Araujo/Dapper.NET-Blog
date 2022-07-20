using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.ProfileScreen
{
    public class ListProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Profile List");
            Console.WriteLine("=================");
            List();
            Console.ReadKey();
            MenuProfileScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var profiles = repository.Get();
            foreach (var item in profiles)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - ({item.Slug})");
            }
        }
    }
}
