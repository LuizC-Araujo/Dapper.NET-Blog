using System;

using Blog_Dapper.Shared;
using Blog_Dapper.Screens.TagScreens;
using Blog_Dapper.Screens.UserScreen;
using Blog_Dapper.Screens.ProfileScreen;
using Blog_Dapper.Screens.CategoryScreen;
using Blog_Dapper.Screens.UserRoleScreen;

namespace Blog_Dapper.Screens
{
    public class StartMenuScreen
    {
        public static object UserTagScreen { get; private set; }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Blog - Dapper");
            Console.WriteLine("=========================");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine();
            Console.WriteLine("1 - User Management");
            Console.WriteLine("2 - Profile Management");
            Console.WriteLine("3 - Category Management");
            Console.WriteLine("4 - Tag Management");
            Console.WriteLine("5 - Link Profile/User");
            Console.WriteLine("6 - Link Post/Tag");
            Console.WriteLine("7 - Reports");
            Console.WriteLine();
            Console.WriteLine();

            var option = Choose.ChooseNumberOnMenu();

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuProfileScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    MenuUserRoleScreen.Load();
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default: Load(); break;
            }
        }
    }
}
