using System;
using System.IO;

namespace FizzWriter
{
    public class FizzBuzzWriter
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("FizzBuzz.txt"))
                {
                    for (int i = 1; i <= 300; i++)
                    {
                        sw.WriteLine(GetFizzBuzz(i));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

        public static string GetFizzBuzz(int number)
        {
            string result = number.ToString();

            if (number % 3 == 0 && number % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if ((number.ToString().Contains("3") || number % 3 == 0))
            {
                result = "Fizz";
            }
            else if ((number.ToString().Contains("5") || number % 5 == 0))
            {
                result = "Buzz";
            }
            return result;
        }
    }
}
