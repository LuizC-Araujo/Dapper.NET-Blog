using System;

using Blog_Dapper.Models;
using Blog_Dapper.Repositories;

namespace Blog_Dapper.Screens.TagScreens
{
    public class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tag List");
            Console.WriteLine("=================");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.Get();
            foreach (var item in tags)
            {
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
            }
        }
    }
}
