using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void WriteSmallGreeting(string greeting)
        {
            if (greeting.Length <= 10)
                Console.WriteLine(greeting);
            else
                WriteBigGreeting(greeting);
        }

        static void WriteBigGreeting(string greeting)
        {
            Console.WriteLine(greeting);
        }

        static void Main(string[] args)
        {
            string greeting = "Happy New Year";
            WriteSmallGreeting(greeting);

            Console.ReadKey();
        }
    }
}
