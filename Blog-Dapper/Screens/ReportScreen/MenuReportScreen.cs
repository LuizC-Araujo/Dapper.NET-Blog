using Blog_Dapper.ReportScreen;
using Blog_Dapper.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.ReportScreen
{
    public class MenuReportScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Reports");
            Console.WriteLine("==================");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Users and Profile");
            Console.WriteLine("2 - Listar Categorias com quantidade de posts");
            Console.WriteLine("3 - Listas Tags com quantidade de posts");
            Console.WriteLine("4 - Listar Posts de uma Categoria");
            Console.WriteLine("5 - Listas todos os Posts com suas Categorias");
            Console.WriteLine("6 - Listas todos os Posts com suas Tags");
            Console.WriteLine("7 - Voltar ao Menu");
            Console.WriteLine();
            Console.WriteLine();

            var option = Choose.ChooseNumberOnMenu();

            switch (option)
            {
                case 1:
                    ListUserProfileScreen.Load();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    StartMenuScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}

