using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            if (name == "Jonny")
                Console.WriteLine("Hi, Jonny");
            else
                Console.WriteLine("User is not recognized");

            Console.ReadKey();
        }
    }
}
