using System;

//The Fibonacci numbers are the integers in the following sequence:
//    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
//By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each 
//subsequent number is the sum of the previous two.

//Write a command line program which prompts the user for an integer value and display
//the Fibonacci sequence leading up to that number.

//```
//Please enter the Fibonacci number: 25
//0, 1, 1, 2, 3, 5, 8, 13, 21
//```

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Fibonacci number: ");
            int maxFibonacciNumber = int.Parse(Console.ReadLine());
            int currentFibonacciNumber = 0;

            int[] previousTwoFibonacciNumbers = new int[] { 0, 1 };
            string result = "0, 1";

            while (true)
            {

                //calculate the latest fibonacci number
                currentFibonacciNumber = previousTwoFibonacciNumbers[0] + previousTwoFibonacciNumbers[1];

                //exit the loop if we are above the max number
                if (currentFibonacciNumber > maxFibonacciNumber)
                {
                    break;
                }
                else
                {
                    //add it to the result string
                    result += ", " + currentFibonacciNumber;
                    previousTwoFibonacciNumbers[0] = previousTwoFibonacciNumbers[1];

                    //update the previousTwo array
                    previousTwoFibonacciNumbers[1] = currentFibonacciNumber;

                }

            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
