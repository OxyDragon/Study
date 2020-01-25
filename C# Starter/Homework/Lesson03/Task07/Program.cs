using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello, ";
            string secondString = "Word!";

            string concatenation = firstString + secondString;
            string interpolation = $"{firstString}{secondString}";

            Console.WriteLine(concatenation);
            Console.WriteLine(interpolation);

            // insertion
            Console.WriteLine("{0}{1}", firstString, secondString);

            Console.ReadKey();
        }
    }
}
