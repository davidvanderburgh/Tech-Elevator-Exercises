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

            if (n > 1)
            {
                for (int i = n; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result.Add(i);
                    }
                }

                if (result.Count == 0)
                {
                    result.Add(n);
                }

            }

            return result;
        }

    }
}
