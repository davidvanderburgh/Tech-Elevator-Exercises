using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceThirdClass : PostalService
    {
        public override double CalculateRate(int distance, double weight)
        {
            double rate = 0.0;
            if (weight >= 0 && weight <= 2)
            {
                rate = 0.0020;
            }
            else if (weight >= 3 && weight <= 8)
            {
                rate = 0.0022;
            }
            else if (weight >= 9 && weight <= 15)
            {
                rate = 0.0024;
            }
            else if (weight >= 16 && weight <= (3 * 16))
            {
                rate = 0.0150;
            }
            else if (weight >= (4 * 16) && weight <= (8 * 16))
            {
                rate = 0.0160;
            }
            else if (weight >= (9 * 16))
            {
                rate = 0.0170;
            }
            return rate * distance;
        }

        public override string ToString()
        {
            return "Postal Service (3rd Class)";
        }
    }
}
