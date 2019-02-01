using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int number)
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else if (number % 3 == 0 || number.ToString().Contains("3"))
                {
                    return "Fizz";
                }
                else if (number % 5 == 0)
                {
                    return "Buzz";
                }
                else
                {
                    return number.ToString();
                }
            }
            else
            {
                return "";
            }
        }

    }
}
