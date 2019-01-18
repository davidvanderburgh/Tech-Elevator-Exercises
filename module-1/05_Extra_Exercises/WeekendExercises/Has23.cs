﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an int array length 2, return true if it contains a 2 or a 3.
        has23([2, 5]) → true
        has23([4, 3]) → true
        has23([4, 5]) → false
        */
        public bool Has23(int[] nums)
        {
            if (nums[0] == 2 || nums[1] == 2)
            {
                return true;
            }
            else if (nums[0] == 3 || nums[1] == 3)
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
