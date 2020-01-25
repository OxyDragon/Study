using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("my dear misterious penpal, please input some magical number, " +
                "which must be reborn to Fibonachi essence");
            string magicalNumber = Console.ReadLine();

            if (int.TryParse(magicalNumber, out int fibonacci))
            {
                int currentNumber = 1;

                if (fibonacci != 0 && fibonacci != 1)
                {
                    currentNumber = 2;
                    int previousNumber = 1;

                    int counter = 2;
                    while (counter < fibonacci)
                    {
                        int tempNumber = currentNumber;
                        currentNumber += previousNumber;
                        previousNumber = tempNumber;

                        counter++;
                    }
                }

                Console.WriteLine(currentNumber);
            }

            Console.ReadKey();
        }
    }
}
