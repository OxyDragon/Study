using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string;

            Console.WriteLine("Please, input your name and surname");
            @string = Console.ReadLine();

            Console.WriteLine(@string);

            Console.ReadKey();
        }
    }
}
