using System;

using Blog_Dapper.Models;
using Blog_Dapper.Shared;
using Blog_Dapper.Repositories;

namespace Blog_Dapper.Screens.CategoryScreen
{
    public class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Category Delete");
            Console.WriteLine("=================");
            Console.WriteLine("0 - Back to Menu");
            Console.WriteLine("Id to delete: ");

            var id = Choose.ChooseId();

            if (id == 0)
                MenuCategoryScreen.Load();
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
