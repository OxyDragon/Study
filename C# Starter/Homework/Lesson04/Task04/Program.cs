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
            Console.WriteLine("Enter your number");
            string number = Console.ReadLine();

            if (int.TryParse(number, out int result))
            {
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Very bad!");
                        break;

                    case 2:
                        Console.WriteLine("Bad");
                        break;

                    case 3:
                        Console.WriteLine("Satisfactory");
                        break;

                    case 4:
                        Console.WriteLine("Good");
                        break;

                    case 5:
                        Console.WriteLine("Excellent");
                        break;
                }
            }
            else
                Console.WriteLine("Invalid input");

            Console.ReadKey();
        }
    }
}
