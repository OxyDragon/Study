using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static string GetInsuranceNumber(string name, string surname, int age)
        {
            string insuranceNumber = "";

            string nameNumber = NameNumber(name);
            string surnameNumber = SurnameNumber(surname);
            string ageNumber = AgeNumber(age);

            insuranceNumber = nameNumber + '-' + surnameNumber + '-' + ageNumber;

            return insuranceNumber;
        }

        #region Generate Numbers

        static string NameNumber(string name)
        {
            string result = "";

            int nameNumber = (int)Math.Pow(name.Length, 2);

            Random random = new Random();
            int number = random.Next(name.Length, nameNumber);

            string tempNumber = Convert.ToString(number);
            if (tempNumber.Length == 1)
                tempNumber = "0" + tempNumber;

            result += tempNumber;

            return result;
        }

        static string SurnameNumber(string surname)
        {
            string result = "";

            int surnameNumber = (int)Math.Pow(surname.Length, 2);

            Random random = new Random();
            int number = random.Next(surname.Length, surnameNumber);

            string tempNumber = Convert.ToString(number);
            if (tempNumber.Length == 1)
                tempNumber = "0" + tempNumber;

            result += tempNumber;

            return result;
        }

        static string AgeNumber(int age)
        {
            string result = "";

            Random random = new Random();
            int number = random.Next(0, age * 4);

            string tempNumber = Convert.ToString(number);
            if (tempNumber.Length == 1)
                tempNumber = "0" + tempNumber;

            result += tempNumber;

            return result;
        }

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            if (int.TryParse(name, out int result))
                Console.WriteLine("Invalid input");
            else
            {
                Console.WriteLine("Enter your surname");
                string surname = Console.ReadLine();

                if (int.TryParse(surname, out int result2))
                    Console.WriteLine("Invalid input");
                else
                {
                    Console.WriteLine("Enter your age");
                    string stringAge = Console.ReadLine();

                    if (int.TryParse(stringAge, out int age))
                    {
                        string result3 = GetInsuranceNumber(name, surname, age);
                        Console.WriteLine(result3);
                    }
                    else
                        Console.WriteLine("Invalid input");

                    Console.ReadKey();
                }
            }
        }
    }
}
