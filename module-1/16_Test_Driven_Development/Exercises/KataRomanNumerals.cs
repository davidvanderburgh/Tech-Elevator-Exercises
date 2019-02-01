using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        public string ConvertToRomanNumeral(int n)
        {
            string result = "";
            while (n >= 1)
            {
                n -= 1;
                result += "I";
            }

            return result;
        }
    }
}
