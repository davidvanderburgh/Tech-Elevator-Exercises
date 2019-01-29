using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalService : IDeliveryDriver
    {
        public virtual double CalculateRate(int distance, double weight)
        {
            return 0.0;
        }
    }
}
