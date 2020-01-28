using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static (string, double) GetAllTerrainVehicleData(string planetName, double distance)
        {
            string allTerrainVehicle = GetAllTerrainVehicle(planetName);
            double totalFuel = GetTotalFuel(allTerrainVehicle, distance);

            return (allTerrainVehicle, totalFuel);
        }

        static string GetAllTerrainVehicle(string planetName)
        {
            string allTerrainVehicle = default;

            switch (planetName)
            {
                case "Mars":
                    allTerrainVehicle = "Houston";
                    break;

                case "Mercury":
                    allTerrainVehicle = "Lada";
                    break;

                case "Saturn":
                    allTerrainVehicle = "Odin";
                    break;
            }

            return allTerrainVehicle;
        }

        static double GetTotalFuel(string allTerrainVehicle, double distance)
        {
            const double coefficient = 1.5;
            double totalFuel = default;

            switch (allTerrainVehicle)
            {
                case "Houston":
                    totalFuel = 10 * distance * coefficient;
                    break;

                case "Lada":
                    totalFuel = 40 * distance * coefficient;
                    break;

                case "Odin":
                    totalFuel = 120 * distance * coefficient;
                    break;
            }

            return totalFuel;
        }

        static void Main(string[] args)
        {
            string allTerrain = default;
            double fuel = default;

            Console.WriteLine("enter planet name");
            string planetName = Console.ReadLine();

            Console.WriteLine("enter distance");
            string stringDistance = Console.ReadLine();

            if (double.TryParse(stringDistance, out double distance))
            {
                (string, double) result = GetAllTerrainVehicleData(planetName, distance);
                allTerrain = result.Item1;
                fuel = result.Item2;

                Console.WriteLine($"Your all-terrain  vehicle is {allTerrain}. you need {fuel} tons of fuel");
            }
            else
                Console.WriteLine("Invalid input");

            Console.ReadKey();
        }
    }
}
