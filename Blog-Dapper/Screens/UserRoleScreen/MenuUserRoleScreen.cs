using Blog_Dapper.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.UserRoleScreen
{
    public class MenuUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Roles Management");
            Console.WriteLine("==================");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine();
            Console.WriteLine("1 - List Users with Profiles");
            Console.WriteLine("2 - Link User to Profile");
            Console.WriteLine("3 - Back to Menu");
            Console.WriteLine();
            Console.WriteLine();

            var option = Choose.ChooseNumberOnMenu();

            switch (option)
            {
                case 1:
                    ListUserRoleScreen.Load();
                    break;
                case 2:
                    LinkUserRoleScreen.Load();
                    break;
                case 3:
                    StartMenuScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
