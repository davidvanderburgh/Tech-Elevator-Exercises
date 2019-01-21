using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if the first instance of "x" in the string is immediately 
         followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            //if our string contains 'x' and the length of the string is at least 2
            if (str.Contains('x') && str.Length >= 2)
            {
                int indexOfFirstx = str.IndexOf('x');

                //if it's not the last position in the string
                if (indexOfFirstx != str.Length-1)
                {
                    if (str[indexOfFirstx+1] == 'x')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
