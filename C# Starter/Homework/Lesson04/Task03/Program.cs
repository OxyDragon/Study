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
            Console.WriteLine("Input your number, please");
            string number = Console.ReadLine();

            if (int.TryParse(number, out int result))
                Console.WriteLine("You printed a number: " + result);
            else
                Console.WriteLine("Invalid input");

            Console.ReadKey();
        }
    }
}
