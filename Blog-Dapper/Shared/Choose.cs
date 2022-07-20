using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Shared
{
   public class Choose
    {
        public static int ChooseNumberOnMenu()
        {
            bool verification;
            int option, count = 0;
            do
            {
                if (count > 0)
                {
                    Console.WriteLine("Não é um número. Digite novamente: ");
                }
                count++;
                var choose = Console.ReadLine();
                verification = Int32.TryParse(choose, out option);
            } while (verification.Equals(false));

            return option;
        }

        public static int ChooseIdOnDelete()
        {
            string option;
            int id, count = 0;
            do
            {
                if (count > 0)
                    Console.WriteLine("Por favor, digite um número!");
                count++;
                option = Console.ReadLine();
            } while (Int32.TryParse(option, out id).Equals(false));

            return id;
        }
    }
}
