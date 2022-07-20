using Blog_Dapper.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.CategoryScreen
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Category Management");
            Console.WriteLine("==================");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine();
            Console.WriteLine("1 - List Categories");
            Console.WriteLine("2 - Create Category");
            Console.WriteLine("3 - Update Category");
            Console.WriteLine("4 - Delete Category");
            Console.WriteLine("5 - Back to Menu");
            Console.WriteLine();
            Console.WriteLine();

            var option = Choose.ChooseNumberOnMenu();

            switch (option)
            {
                case 1:
                    ListCategoryScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    UpdateCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCategoryScreen.Load();
                    break;
                case 5:
                    StartMenuScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
