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
         Given an int array, return true if the array contains 2 twice, or 3 twice. 
         The array will be length 0, 1, or 2.
         double23([2, 2]) → true
         double23([3, 3]) → true
         double23([2, 3]) → false
         */
        public bool Double23(int[] nums)
        {
            //if length is != 2
            //  return false
            //else
            //  if nums[0] == 2 && nums[1] == 2
            //      return true;
            //  else if nums[0] == 3 && nums[1] == 3
            //      return true;
            if (nums.Length !=2)
            {
                return false;
            }
            else
            {
                if (nums[0] == 2 && nums[1] == 2)
                {
                    return true;
                }
                else if (nums[0] == 3 && nums[1] == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
