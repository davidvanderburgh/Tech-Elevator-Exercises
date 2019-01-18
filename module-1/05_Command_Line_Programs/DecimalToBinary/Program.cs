using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Please enter in a series of decimal values(separated by spaces): 460 8218 1 31313 987654321

            //460 in binary is 111001100
            //8218 in binary is 10000000011010
            //1 in binary is 1
            //31313 in binary is 111101001010001
            //987654321 in binary is 111010110111100110100010110001

            // read in multiple line spaced integers
            // put integers into an array
            // cycle through the array
            //  spit out convertion text lines

            Console.Write("Please enter in a series of decimal values(separated by spaces): ");
            
            string[] inputNumbers = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine(inputNumbers[i] + " in binary is " + 
                    Convert.ToString(int.Parse(inputNumbers[i]), 2));
            }

            Console.ReadLine();
        }
    }
}
