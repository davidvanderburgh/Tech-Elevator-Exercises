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
                    continue;
                }

                Console.Write("(P)ounds or (O)unces? ");

                //Entering "p" or "o" (or "P" or "O"), or start the loop again
                string poundsOrOunces = Console.ReadLine().ToLower();

                if (!(poundsOrOunces == "o" || poundsOrOunces == "p"))
                {
                    continue;
                }

                Console.Write("What distance will it be travelling? ");

                //Entering a valid integer, or start the loop again
                if (!int.TryParse(Console.ReadLine(), out int distance))
                {
                    continue;
                }
                if (distance < 0)
                {
                    continue;
                }

                //Print the delivery method cost table

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
    }
}
