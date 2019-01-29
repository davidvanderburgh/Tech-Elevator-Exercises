using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU : IDeliveryDriver
    {
        public virtual double CalculateRate(int distance, double weight)
        {
            return 0.00;
        }
    }
}
