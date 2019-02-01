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
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return "";
            }
        }

    }
}
