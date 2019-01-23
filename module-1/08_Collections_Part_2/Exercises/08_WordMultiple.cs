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
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            // create a dictionary
            // turn words input into a List
            // look at every word in wordsList
            //  if it's the first time we've seen the word, 
            //      set its value to false
            //  if the last index of the word at the current index is NOT the same
            //      set its value to true


            Dictionary<string, bool> wordMultiples = new Dictionary<string, bool>();

            List<string> wordsList = new List<string>(words);

            for (int i = 0; i < wordsList.Count; i++)
            {
                if (!wordMultiples.ContainsKey(wordsList[i]))
                {
                    wordMultiples[wordsList[i]] = false;
                }
                if (wordsList.LastIndexOf(wordsList[i]) != i)
                {
                    wordMultiples[wordsList[i]] = true;
                }
            }

            //Dictionary<string, int> wordCount = new Dictionary<string, int>();

            //foreach (string word in words)
            //{
            //    if (!wordCount.ContainsKey(word))
            //    {
            //        wordCount[word] = 1;
            //    }
            //    else
            //    {
            //        wordCount[word]++;
            //    }
            //}

            //foreach (KeyValuePair<string, int> entry in wordCount)
            //{
            //    if (entry.Value >= 2)
            //    {
            //        wordMultiples[entry.Key] = true;
            //    }
            //    else
            //    {
            //        wordMultiples[entry.Key] = false;
            //    }
            //}


            return wordMultiples;
        }
    }
}
