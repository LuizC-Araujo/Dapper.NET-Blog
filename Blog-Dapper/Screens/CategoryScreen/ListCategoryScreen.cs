using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.CategoryScreen
{
    public class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Category List");
            Console.WriteLine("=================");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.Get();

            foreach (var item in categories)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
            }
        }
    }
}
