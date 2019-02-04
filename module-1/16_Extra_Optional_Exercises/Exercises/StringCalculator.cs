using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            //Not a number
            //Wrong delimiter
            //Single entry
            //Negative numbers
            //Positive numbers

            int result = 0;

            if (numbers != "")
            {
                //split entry on delimiter
                char[] separators = new char[] { '\n', ',' };
                string[] entryStrings = numbers.Split(separators);

                for (int i = 0; i < entryStrings.Length; i++)
                {
                    if (int.TryParse(entryStrings[i], out int entryInt))
                    {
                        result += entryInt;
                    }
                }
            }
            
            return result;
        }
    }
}
