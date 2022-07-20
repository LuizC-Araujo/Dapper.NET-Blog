using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.CategoryScreen
{
    public class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Category Create");
            Console.WriteLine("=================");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = int.Parse(id), 
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine("Categoria atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a categoria!");
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}

