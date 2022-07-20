using System;

using Blog_Dapper.Models;
using Blog_Dapper.Repositories;

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
           
            string option;
            int id, count = 0;
            do
            {
                if (count > 0)
                    Console.WriteLine("Por favor, digite um número!");
                count++;
                option = Console.ReadLine();
            } while (Int32.TryParse(option, out id).Equals(false));

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
