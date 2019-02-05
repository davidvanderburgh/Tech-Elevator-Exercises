using System;
using System.IO;
using System.Collections.Generic;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string filePath = Console.ReadLine();

            Console.WriteLine("What is the search word you are looking for?");
            string searchWord = Console.ReadLine();

            Console.WriteLine("Should the search be case sensitive? (Y\\N)");
            string caseSensitiveEntry = Console.ReadLine();
            bool caseSensitive = true;

            if (caseSensitiveEntry == "N" || caseSensitiveEntry == "n")
            {
                caseSensitive = false;
            }
            else if (caseSensitiveEntry != "Y" && caseSensitiveEntry != "y")
            {
                Console.WriteLine("Error: Invalid entry.  Assuming case sensitive search");
            }


            int lineNumber = 1;
            Dictionary<int, string> searchWordLineTextPair = new Dictionary<int, string>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        //Read in line
                        string line = sr.ReadLine();

                        if ((caseSensitive && line.Contains(searchWord)) ||
                            (!caseSensitive && line.ToLower().Contains(searchWord.ToLower())))
                        {
                            searchWordLineTextPair[lineNumber] = line;
                        }

                        //Increment line number as the last expression
                        lineNumber++;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            if (searchWordLineTextPair.Count == 0)
            {
                Console.WriteLine("I could not find that string");
            }
            else
            {
                foreach (KeyValuePair<int, string> entry in searchWordLineTextPair)
                {
                    Console.WriteLine($"{entry.Key}) {entry.Value}");
                }
            }

            Console.ReadLine();
        }
    }
}
