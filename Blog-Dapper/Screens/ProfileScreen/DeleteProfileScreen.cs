using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using Blog_Dapper.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.ProfileScreen
{
    internal class DeleteProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete Profile");
            Console.WriteLine("=================");
            Console.WriteLine("Id: ");

            var id = Choose.ChooseIdOnDelete();

            if (id == 0)
                MenuProfileScreen.Load();
            var retorno = Delete(id);
            Console.ReadKey();
            if (!retorno)
                Load();
            else
                MenuProfileScreen.Load();
        }

        private static bool Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Profile excluído com sucesso");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o profile");
                Console.WriteLine($"Erro: {ex.Message}");
                return false;
            }
        }
    }
}
