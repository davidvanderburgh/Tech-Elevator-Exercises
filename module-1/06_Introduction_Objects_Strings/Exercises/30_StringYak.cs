﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Suppose the string "yak" is unlucky. Given a string, return a version where all the 
         "yak" are removed, but the "a" can be any char. The "yak" strings will not overlap.
         StringYak("yakpak") → "pak"
         StringYak("pakyak") → "pak"
         StringYak("yak123ya") → "123ya"
         */
        public string StringYak(string str)
        {
            string result = str;
            int foundIndexOfYak;

            while (result.Contains("yak"))
            {
                foundIndexOfYak = result.IndexOf("yak");
                result = result.Remove(foundIndexOfYak, 3);
            }

            return result;
        }
    }
}