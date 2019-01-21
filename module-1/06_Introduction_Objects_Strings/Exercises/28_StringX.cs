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
        Given a string, return a version where all the "x" have been removed. Except an "x" 
        at the very start or end should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            if (str.Length > 2)
            {
                string result = str.Substring(0, 1);
                for (int i = 1; i < str.Length - 1; i++)
                {
                    if (str[i] != 'x')
                    {
                        result += str[i];
                    }
                }
                result += str.Substring(str.Length - 1);

                return result;
            }
            else
            {
                return str;
            }
        }
    }
}
