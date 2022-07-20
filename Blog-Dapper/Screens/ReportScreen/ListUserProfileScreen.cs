using System;

using Blog_Dapper.Screens.ReportScreen;
using Blog_Dapper.Screens.UserRoleScreen;

namespace Blog_Dapper.ReportScreen
{
    public class ListUserProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Usuário e seu Profiles");
            Console.WriteLine("============================");
            var users = ListUserRoleScreen.ReturnList();

            foreach (var user in users)
            {
                Console.Write($"{user.Name}, {user.Email}");
                foreach (var role in user.Roles)
                {
                    Console.Write($", {role.Name}");
                }
                Console.WriteLine();   
            }

            Console.ReadKey();
            MenuReportScreen.Load();
        }
    }
}
