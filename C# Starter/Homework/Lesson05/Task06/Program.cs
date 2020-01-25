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
            Console.WriteLine("Enter your name, please");
            string name = Console.ReadLine();

            Console.WriteLine("Enter count");
            string count = Console.ReadLine();

            if (int.TryParse(count, out int convertedCount))
            {
                Console.WriteLine("Enter a price you can afford");
                string price = Console.ReadLine();

                if (int.TryParse(price, out int convertedPrice))
                {
                    Console.WriteLine("Do you have discount");
                    string discount = Console.ReadLine().ToLower();

                    double total = 0;
                    if (discount == "yes" && convertedPrice > 1000)
                        total = convertedCount * convertedPrice * 0.75;
                    else if (discount == "no")
                        total = convertedCount * convertedPrice;

                    Console.WriteLine("Hello, " + name + "! Total sum is " + total);
                }
            }

            Console.ReadKey();
        }
    }
}
