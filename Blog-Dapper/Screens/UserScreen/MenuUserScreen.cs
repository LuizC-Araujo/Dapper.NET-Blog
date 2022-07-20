using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.UserScreen
{
    public class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("User Management");
            Console.WriteLine("==================");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine();
            Console.WriteLine("1 - List Users");
            Console.WriteLine("2 - Create User");
            Console.WriteLine("3 - Update User");
            Console.WriteLine("4 - Delete User");
            Console.WriteLine("5 - Back to Menu");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                case 5:

                    break;
                default: Load(ListUserScreen); break;
            }
        }
    }
}
