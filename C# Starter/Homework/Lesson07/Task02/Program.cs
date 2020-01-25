using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static string Function()
        {
            string word = "Hello, world!";

            return word;
        }

        static void Main(string[] args)
        {
            string @string = Function();
            Console.WriteLine(@string);

            Console.ReadKey();
        }
    }
}
