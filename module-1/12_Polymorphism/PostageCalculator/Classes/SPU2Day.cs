using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU2Day : SPU
    {
        public override double CalculateRate(int distance, double weight)
        {
            return (weight * 0.050 * distance) / 16;
        }

        public override string ToString()
        {
            return "SPU (2-Day Business)";
        }
    }
}
