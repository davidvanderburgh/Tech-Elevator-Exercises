using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPUNextDay : SPU
    {
        public override double CalculateRate(int distance, double weight)
        {
            return (weight * 0.075 * distance) / 16;
        }

        public override string ToString()
        {
            return "SPU (Next Day)";
        }
    }
}
