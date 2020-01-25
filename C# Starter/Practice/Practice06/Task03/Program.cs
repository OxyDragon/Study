using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Olya";
            string name2 = "Vita";
            string name3 = "Rita";

            string password1 = "123olya";
            string password2 = "123vita";
            string password3 = "123rita";

            Console.WriteLine("please, enter your name");
            string name = Console.ReadLine();

            Console.WriteLine(" please, enter your password");
            string password = Console.ReadLine();

            if (name == name1 && password1 == password)
            {
                Console.WriteLine("successful " + name1);
            }
            else if (name == name2 && password2 == password)
            {
                Console.WriteLine($"successful {name}");
            }
            else if (name == name3 && password3 == password)
            {
                Console.WriteLine("successful {0}", name);
            }
            else
                Console.WriteLine("Invalid input");

            Console.ReadKey();
        }
    }
}
