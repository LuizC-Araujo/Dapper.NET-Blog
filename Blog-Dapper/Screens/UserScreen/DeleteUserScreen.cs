using System;

using Blog_Dapper.Shared;
using Blog_Dapper.Models;
using Blog_Dapper.Repositories;

namespace Blog_Dapper.Screens.UserScreen
{
    public class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("User Delete");
            Console.WriteLine("=================");
            Console.WriteLine("Id to delete: ");

            var id = Choose.ChooseIdOnDelete();

            if (id == 0)
                MenuUserScreen.Load();
            var retorno = Delete(id);
            Console.ReadKey();
            if (!retorno)
                Load();
            else
                MenuUserScreen.Load();
        }

        private static bool Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário deletado com sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível deletar o usuário!");
                Console.WriteLine($"Erro: {ex.Message}");
                return false;
            }
        }
    }
}
