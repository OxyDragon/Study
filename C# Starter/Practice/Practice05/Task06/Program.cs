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
            string convertedRocketType = "";

            while (true)
            {
                Console.WriteLine("Which type of rocket do you use?");
                string rocketType = Console.ReadLine().ToLower();

                if (!(rocketType == "voyager" || rocketType == "thor" || rocketType == "odin"))
                    Console.WriteLine("Invalid input. Please, try again.");
                else
                {
                    convertedRocketType = rocketType;

                    break;
                }
            }

            int convertedDistance = 0;
            while (true)
            {
                Console.WriteLine("What is the distance (in km)?");
                string stringDistance = Console.ReadLine();

                if (!(int.TryParse(stringDistance, out int distance)))
                    Console.WriteLine("Invalid input. Please, try again.");
                else
                {
                    convertedDistance = distance;

                    break;
                }
            }

            string convertedMode = "";
            while (true)
            {
                Console.WriteLine("Which mode did you chose?");
                string mode = Console.ReadLine().ToLower();

                if (!(mode == "default" || mode == "boosted"))
                    Console.WriteLine("Invalid input. Please, try again.");
                else
                {
                    convertedMode = mode;

                    break;
                }
            }

            const int value = 10;
            int coefficient = 1;

            if (convertedRocketType != "voyager")
                coefficient = 2;

            if (convertedMode == "boosted")
                coefficient *= 2;

            int totalFuel = value * coefficient * convertedDistance;
            Console.WriteLine($"Total fuel consumption for journey is: {totalFuel} tons.");

            Console.ReadKey();
        }
    }
}
