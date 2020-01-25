using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();

            if (int.TryParse(age, out int result) && result >= 0)
            {
                Console.WriteLine("Enter your marital");
                string marital = Console.ReadLine();

                if (marital == "Married" || marital == "Not married")
                    Console.WriteLine($"Name: {name}. Age: {age}. Marital status: {marital}");
                else
                    Console.WriteLine("invalid input");
            }

            Console.ReadLine();
        }
    }
}
