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
         Given an array of ints, return true if .. 1, 2, 3, .. appears in the array somewhere.
         array123([1, 1, 2, 3, 1]) → true
         array123([1, 1, 2, 4, 1]) → false
         array123([1, 1, 2, 1, 2, 3]) → true
         */
        public bool Array123(int[] nums)
        {
            bool hasOne = false;
            bool hasTwo = false;
            bool hasThree = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    hasOne = true;
                }
                else if (nums[i] == 2)
                {
                    hasTwo = true;
                }
                else if (nums[i] == 3)
                {
                    hasThree = true;
                }
            }
            return (hasOne && hasTwo && hasThree);
        }
    }
}
