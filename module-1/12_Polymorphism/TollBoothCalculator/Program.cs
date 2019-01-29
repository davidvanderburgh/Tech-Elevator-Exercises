using System;
using System.Collections.Generic;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>()
            {
                new Car(false),
                new Car(true),
                new Tank(),
                new Truck(4),
                new Truck(6),
                new Truck(8)
            };

            Random random = new Random();
            int totalMiles = 0;
            double totalRevenue = 0.00;

            Console.WriteLine("{0,-20}{1,-20}{2,-20}",
                 "Vehicle",
                 "Distance Travelled",
                 "Toll $");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (IVehicle vehicle in vehicles)
            {
                int distanceTravelled = random.Next(10, 240);
                double tollCost = vehicle.CalculateToll(distanceTravelled);
                string tollCostUSD = String.Format("{0:C2}", tollCost);

                Console.WriteLine("{0,-20}{1,-20}{2,-20}",
                    vehicle,
                    distanceTravelled,
                    tollCostUSD);

                totalMiles += distanceTravelled;
                totalRevenue += tollCost;
            }

            Console.WriteLine();
            Console.WriteLine("Total Miles Travelled: " + totalMiles);
            string totalRevenueString = String.Format("{0:C2}", totalRevenue);
            Console.WriteLine("Total Tollbooth Revenue: " + totalRevenueString);

            Console.ReadLine();
        }
    }
}
