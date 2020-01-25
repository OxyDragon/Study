using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static bool RestaurantBooking(string name, int tableNumber, double hour, string dayOfWeek, int dayOfMonth, string order)
        {
            bool result = true;

            if (tableNumber == 666 && dayOfWeek == "Friday" && dayOfMonth == 13)
            {
                Console.WriteLine("Error");

                result = false;
            }
            else
                Console.WriteLine($"Dear, {name}! You booked a place at our restaurant at table №{tableNumber} at {dayOfMonth} on {hour}. " +
                    $"Your order is: {order}");

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, please");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the day of month");
            string dayOfMonth = Console.ReadLine();

            if (int.TryParse(dayOfMonth, out int convertedDayOfMonth) && (convertedDayOfMonth <= 31 && convertedDayOfMonth > 0))
            {
                Console.WriteLine("Enter the day of week");
                string dayOfWeek = Console.ReadLine();

                dayOfWeek = dayOfWeek.ToLower();
                if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday"
                    || dayOfWeek == "thursday" || dayOfWeek == "friday" || dayOfWeek == "saturday" || dayOfWeek == "sunday")
                {
                    Console.WriteLine("Enter an hour");
                    string hour = Console.ReadLine();

                    if (double.TryParse(hour, out double convertedHour) && (convertedHour > 7 && convertedHour < 23))
                    {
                        Console.WriteLine("Enter the number of table");
                        string tableNumber = Console.ReadLine();

                        if (int.TryParse(tableNumber, out int convertedTableNumber)
                            && (convertedTableNumber < 700 && convertedTableNumber > 0))
                        {
                            Console.WriteLine("Enter your order");
                            string order = Console.ReadLine();

                            bool booking = RestaurantBooking(name, convertedTableNumber, convertedHour,
                                dayOfWeek, convertedDayOfMonth, order);
                        }
                        else
                            Console.WriteLine("Invalid input");
                    }
                    else
                        Console.WriteLine("Invalid input");
                }
                else
                    Console.WriteLine("Invalid input");
            }
            else
                Console.WriteLine("Invalid input");

            Console.ReadKey();
        }
    }
}
