using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    class Car : IVehicle
    {
        public bool HasTrailer { get; }

        public Car(bool hasTrailer)
        {
            HasTrailer = hasTrailer;
        }

        public override string ToString()
        {
            if (HasTrailer)
            {
                return "Car (with trailer)";
            }
            else
            {
                return "Car";
            }
        }

        public double CalculateToll(int distance)
        {
            double toll = 0;
            if (distance >=0)
            {
                toll = distance * 0.020;
                if (HasTrailer)
                {
                    toll += 1.00;
                }
            }
            return toll;
        }
    }
}
