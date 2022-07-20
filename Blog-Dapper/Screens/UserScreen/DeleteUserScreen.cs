using System;

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
