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
         Given 2 int values greater than 0, return whichever value is nearest to 21 
         without going over. Return 0 if they both 
         go over.
         blackjack(19, 21) → 21
         blackjack(21, 19) → 21
         blackjack(19, 22) → 19
         */
        public int Blackjack(int a, int b)
        {
            //a is over
            //  b is not over
            //      return b
            //  else
            //      return 0
            //else
            //  b is not over
            //      return larger of a,b
            //  else
            //      return a
            
            if (a > 21)
            {
                if (b <= 21)
                {
                    return b;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (b <=21)
                {
                    return ((a > b) ? a : b);
                }
                else
                {
                    return a;
                }
            }
        }
    }
}
