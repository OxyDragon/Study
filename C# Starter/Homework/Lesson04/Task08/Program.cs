using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the current day of week");
            string day = Console.ReadLine().ToLower();

            switch (day)
            {
                case "monday":
                case "tuesday":
                    Console.WriteLine("Have a productive week!");
                    break;

                case "wednesday":
                case "thursday":
                    Console.WriteLine("Stay strong!");
                    break;

                case "friday":
                    Console.WriteLine("Relax now!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
