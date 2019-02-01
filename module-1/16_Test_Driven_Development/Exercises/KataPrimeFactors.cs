using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPrimeFactors
    {

        public List<int> Factorize(int n)
        {
            List<int> result = new List<int>();

            while(n % 2 == 0)
            {
                result.Add(2);
                n /= 2;
            }

            int factor = 3;
            while (factor * factor <= n)
            {
                if (n % factor == 0)
                {
                    result.Add(factor);
                    n /= factor;
                }
                else
                {
                    factor += 2;
                }
            }

            if (n > 1)
            {
                result.Add(n);
            }
            return result;
        }
    }
}
