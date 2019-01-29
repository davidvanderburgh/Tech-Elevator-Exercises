using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalServiceFirstClass : PostalService
    {
        public override double CalculateRate(int distance, double weight)
        {
            double rate = 0.0;
            if (weight >= 0 && weight <= 2)
            {
                rate = 0.035;
            }
            else if (weight >=3 && weight <= 8)
            {
                rate = 0.040;
            }
            else if (weight >= 9 && weight <= 15)
            {
                rate = 0.047;
            }
            else if (weight >= 16 && weight <= (3*16))
            {
                rate = 0.195;
            }
            else if (weight >= (4*16) && weight <= (8*16))
            {
                rate = 0.450;
            }
            else if (weight >= (9*16))
            {
                rate = 0.500;
            }
            return rate*distance;
        }

        public override string ToString()
        {
            return "Postal Service (1st Class)";
        }
    }
}
