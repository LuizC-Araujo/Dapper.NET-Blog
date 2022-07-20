using System;

using Blog_Dapper.Shared;

namespace Blog_Dapper.Screens.TagScreens
{
    public class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tag Management");
            Console.WriteLine("==================");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine();
            Console.WriteLine("1 - List Tags");
            Console.WriteLine("2 - Create Tag");
            Console.WriteLine("3 - Update Tag");
            Console.WriteLine("4 - Delete Tag");
            Console.WriteLine("5 - Back to Menu");
            Console.WriteLine();
            Console.WriteLine();
            var option = Choose.ChooseNumberOnMenu();

            switch (option)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
                    break;
                case 5:
                    StartMenuScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
