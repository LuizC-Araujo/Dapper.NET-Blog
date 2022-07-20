using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Shared
{
   public class Choose
    {
        public static int ChooseNumber()
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
    }
}
