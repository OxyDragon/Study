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
            int a = 0;
            int s = 0;

            for (a = 0; a < 1; a++)
            {
                Console.WriteLine("* * * * *");
            }

            for (a = 0; a < 3; a++)
            {
                Console.WriteLine("*       *");
            }

            for (a = 3; a < 4; a++)
            {
                Console.WriteLine("* * * * *");
            }

            for (s = 5; s < 6; s++)
            {
                Console.WriteLine("   *   ");
            }

            for (s = 6; s < 7; s++)
            {
                Console.WriteLine("   *   ");
            }

            for (s = 7; s < 8; s++)
            {
                Console.WriteLine("*-*-*-*");
            }

            for (s = 8; s < 9; s++)
            {
                Console.WriteLine(" *   * ");
            }

            for (s = 9; s < 10; s++)
            {
                Console.WriteLine(" *   *  ");
            }

            Console.ReadKey();
        }
    }
}
