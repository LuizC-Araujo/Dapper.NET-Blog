using System;

using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using Blog_Dapper.Shared;

namespace Blog_Dapper.Screens.TagScreens
{
    public class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete Tag");
            Console.WriteLine("=================");
            Console.WriteLine("Id: ");

            var id = Choose.ChooseId();

            if (id == 0)
                MenuTagScreen.Load();
            var retorno = Delete(id);
            Console.ReadKey();
            if (!retorno)
                Load();
            else
                MenuTagScreen.Load();
        }

        private static bool Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag excluída com sucesso");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a tag");
                Console.WriteLine($"Erro: {ex.Message}");
                return false;
            }
        }
    }
}
