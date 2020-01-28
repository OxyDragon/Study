using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void RegisterCar()
        {
            string manufacturer = GetManufacturer();

            if (manufacturer == null)
            {
                Console.WriteLine("you are blocked");

                return;
            }

            string numberPlate = NumberPlate();
            if (numberPlate == null)
            {
                Console.WriteLine("you are blocked");

                return;
            }

            int? insurancePolicy = InsurancePolicy();
            if (insurancePolicy == null)
            {
                Console.WriteLine("you are blocked");

                return;
            }

            Console.WriteLine($"Your car is {manufacturer}. " +
                $"Your number plate is {numberPlate}. Your insurance policy is {insurancePolicy}. " +
                $"Car registration is succesful.");

        }

        #region Check input

        static string GetManufacturer()
        {
            string manufacturer = default;
            int attempt = 0;

            while (true)
            {
                if (attempt < 3)
                {
                    Console.WriteLine("Input your car manufacturer");
                    manufacturer = Console.ReadLine();

                    if (manufacturer == "Volvo" || manufacturer == "Audi"
                        || manufacturer == "BMW" || manufacturer == "Bugatti" || manufacturer == "Lamborghini")
                        break;

                    Console.WriteLine("Invalid input");

                    attempt++;
                }
                else
                {
                    manufacturer = null;

                    break;
                }
            }

            return manufacturer;
        }

        static string NumberPlate()
        {
            string numberPlate = default;
            int attempt = 0;

            while (true)
            {
                if (attempt < 3)
                {
                    Console.WriteLine("Input your car number plate");
                    numberPlate = Console.ReadLine();

                    if (numberPlate.Length == 9)
                        break;

                    attempt++;
                }
                else
                {
                    numberPlate = null;

                    break;
                }
            }

            return numberPlate;
        }

        static int? InsurancePolicy()
        {
            int? insurancePolicy = default;
            int attempt = 0;

            while (true)
            {
                if (attempt < 3)
                {
                    Console.WriteLine("Input your insurance policy");
                    string stringInsurancePolicy = Console.ReadLine();

                    if (stringInsurancePolicy.Length > 0 && stringInsurancePolicy.Length <= 6)
                    {
                        if (int.TryParse(stringInsurancePolicy, out int intInsurancePolicy))
                        {
                            insurancePolicy = intInsurancePolicy;

                            attempt++;

                            break;
                        }
                        else
                        {
                            insurancePolicy = null;

                            break;
                        }
                    }
                    else
                    {
                        insurancePolicy = null;

                        break;
                    }
                }
            }

            return insurancePolicy;
        }

        #endregion

        static void Main(string[] args)
        {
            RegisterCar();

            Console.ReadKey();
        }
    }
}
