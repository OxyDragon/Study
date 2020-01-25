using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            if (name == "Alex" && password == "pswd1234!")
                Console.WriteLine("Access granted");
            else if (name == "Sergei" && password == "sname1995")
                Console.WriteLine("Access granted");
            else
                Console.WriteLine("Access denied");

            Console.ReadKey();
        }
    }
}
