using Blog_Dapper.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.ProfileScreen
{
    public class MenuProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Profile Management");
            Console.WriteLine("==================");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine();
            Console.WriteLine("1 - List Profiles");
            Console.WriteLine("2 - Create Profile");
            Console.WriteLine("3 - Update Profile");
            Console.WriteLine("4 - Delete Profile");
            Console.WriteLine("5 - Back to Menu");
            Console.WriteLine();
            Console.WriteLine();

            var option = Choose.ChooseNumberOnMenu();

            switch (option)
            {
                case 1:
                    ListProfileScreen.Load();
                    break;
                case 2:
                    CreateProfileScreen.Load();
                    break;
                case 3:
                    UpdateProfileScreen.Load();
                    break;
                case 4:
                    DeleteProfileScreen.Load();
                    break;
                case 5:
                    StartMenuScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
