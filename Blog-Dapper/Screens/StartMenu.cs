using System;

using Blog_Dapper.Shared;
using Blog_Dapper.Screens.TagScreens;
using Blog_Dapper.Screens.UserScreen;

namespace Blog_Dapper.Screens
{
    public class StartMenu
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

            var option = Choose.ChooseNumber();

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
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
