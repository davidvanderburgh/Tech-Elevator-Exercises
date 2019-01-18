using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return the sum of the first 2 elements in the array. If the array length
          is less than 2, just sum up the elements that exist, returning 0 if the array is length 0.
         Sum2([1, 2, 3]) → 3
         Sum2([1, 1]) → 2
         Sum2([1, 1, 1, 1]) → 2
         */
        public int Sum2(int[] nums)
        {
            int sum = 0;
            if (nums.Length == 0)
            {
                sum = 0;
            }
            else if (nums.Length <= 2)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                }                
            }
            else
            {
                sum += nums[0] + nums[1];
            }
            return sum;
        }

    }
}
