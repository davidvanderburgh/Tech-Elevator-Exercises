using System;
using PostageCalculator.Classes;
using System.Collections.Generic;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Write("Please enter the weight of the package? ");

                //Entering a valid integer, or start the loop again
                if (!int.TryParse(Console.ReadLine(), out int weight))
                {
                    //invalid entry
                    PrintError("Entered weight is not a valid integer.");
                    continue;
                }
                if (weight <= 0)
                {
                    //invalid entry
                    PrintError("Entered weight  must be a positive non-zero integer.");
                    continue;
                }

                Console.Write("(P)ounds or (O)unces? ");

                //Entering "p" or "o" (or "P" or "O"), or start the loop again
                string poundsOrOunces = Console.ReadLine().ToLower();

                if (!(poundsOrOunces == "o" || poundsOrOunces == "p"))
                {
                    //invalid entry
                    PrintError("Entry must be O,o,P, or p.");
                    continue;
                }

                Console.Write("What distance will it be travelling? ");

                //Entering a valid integer, or start the loop again
                if (!int.TryParse(Console.ReadLine(), out int distance))
                {
                    //invalid entry
                    PrintError("Entered distance must be a valid integer.");
                    continue;
                }
                if (distance <= 0)
                {
                    PrintError("Entered distance must be a positive non-zero integer.");
                    continue;
                }

                //Print the delivery method cost table
                Console.WriteLine();
                Console.WriteLine("{0,-30}{1,-10}",
                    "Delivery Method",
                    "$ cost");
                Console.WriteLine("---------------------------------------");

                List<IDeliveryDriver> deliveryDrivers = new List<IDeliveryDriver>
                {
                    new PostalServiceFirstClass(),
                    new PostalServiceSecondClass(),
                    new PostalServiceThirdClass(),
                    new FexEd(),
                    new SPU4Day(),
                    new SPU2Day(),
                    new SPUNextDay()
                };

                int poundsMultiplier;

                foreach (IDeliveryDriver deliveryDriver in deliveryDrivers)
                {
                    poundsMultiplier = 1;
                    if (poundsOrOunces == "p")
                    {
                        poundsMultiplier = 16;
                    }
                    string rateUSD = String.Format("{0:C2}", deliveryDriver.CalculateRate(distance, poundsMultiplier*weight));
                    Console.WriteLine("{0,-30}{1,-10}",
                        deliveryDriver,
                        rateUSD
                        );
                }

                Console.WriteLine();
            }

        }

        public static void PrintError(string error)
        {
            Console.WriteLine($"Error: {error}\nStarting from the beginning...\n");
        }
    }
}
