using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void WorkSchedule(string day)
        {
            day = day.ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine("On " + day + " you are driving an Audi");
                    break;

                case "tuesday":
                case "wednesday":
                    Console.WriteLine("On " + day + " you have a rest");
                    break;

                case "thursday":
                case "friday":
                    Console.WriteLine("On " + day + " you are driving a Volvo");
                    break;

                case "saturday":
                case "sunday":
                    Console.WriteLine("On " + day + " you have a rest");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter day");
            string day = Console.ReadLine();

            WorkSchedule(day);

            Console.ReadKey();
        }
    }
}
