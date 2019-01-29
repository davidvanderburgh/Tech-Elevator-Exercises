using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU4Day : SPU
    {
        public override double CalculateRate(int distance, double weight)
        {
            return (weight * 0.0050 * distance) / 16;
        }

        public override string ToString()
        {
            return "SPU (4-Day Ground)";
        }
    }
}
