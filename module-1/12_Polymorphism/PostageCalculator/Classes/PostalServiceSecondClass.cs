using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceSecondClass : PostalService
    {
        public override double CalculateRate(int distance, double weight)
        {
            double rate = 0.0;
            if (weight >= 0 && weight <= 2)
            {
                rate = 0.0035;
            }
            else if (weight >= 3 && weight <= 8)
            {
                rate = 0.0040;
            }
            else if (weight >= 9 && weight <= 15)
            {
                rate = 0.0047;
            }
            else if (weight >= 16 && weight <= (3 * 16))
            {
                rate = 0.0195;
            }
            else if (weight >= (4 * 16) && weight <= (8 * 16))
            {
                rate = 0.0450;
            }
            else if (weight >= (9 * 16))
            {
                rate = 0.0500;
            }
            return rate * distance;
        }

        public override string ToString()
        {
            return "Postal Service (2nd Class)";
        }
    }
}
