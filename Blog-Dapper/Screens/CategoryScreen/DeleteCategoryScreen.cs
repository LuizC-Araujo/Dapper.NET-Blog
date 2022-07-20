using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.CategoryScreen
{
    public class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Category Delete");
            Console.WriteLine("=================");
            Console.WriteLine("Id: ");
            string option;
            int id, count = 0;
            do
            {
                if (count > 0)
                    Console.WriteLine("Por favor, digite um número!");
                count++;
                option = Console.ReadLine();
            } while (Int32.TryParse(option, out id).Equals(false));

            var retorno = Delete(id);
            Console.ReadKey();
            if (!retorno)
                Load();
            else
                MenuCategoryScreen.Load();
        }

        private static bool Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Categoria deletada com sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível deletar a categoria!");
                Console.WriteLine($"Erro: {ex.Message}");
                return false;
            }
        }
    }
}
