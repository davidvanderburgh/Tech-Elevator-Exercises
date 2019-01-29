using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Truck : IVehicle
    {
        public int NumberOfAxles { get; }

        public Truck(int numberOfAxles)
        {
            NumberOfAxles = numberOfAxles;
        }

        public override string ToString()
        {
            return "Track (" + NumberOfAxles + " axels)";
        }

        public double CalculateToll(int distance)
        {
            double toll = 0.0;
            if (distance >= 0)
            {
                if (NumberOfAxles == 4)
                {
                    toll = 0.040 * distance;
                }
                else if (NumberOfAxles == 6)
                {
                    toll = 0.045 * distance;
                }
                else if (NumberOfAxles >= 8)
                {
                    toll = 0.048 * distance;
                }
            }
            return toll;
        }
    }
}
