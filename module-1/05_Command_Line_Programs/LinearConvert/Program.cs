using System;

//Write a program that converts meters to feet and vice-versa.

//The foot to meter conversion formula is:
//    m = f* 0.3048

//The meter to foot conversion formula is:
//    f = m* 3.2808399

//Write a command line program which prompts a user to enter a length, and whether the 
//measurement is in (m) eters or(f)eet.  Convert the length to the opposite measurement, 
//and display the old and new measurements to the console.

//```
//Please enter the length: 58
//Is the measurement in (m) eter, or (f) eet? f
//58f is 17m.
//```

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Is the measurement in (m) eter, or (f) eet? ");
            char feetOrMeter = char.Parse(Console.ReadLine());

            switch (feetOrMeter)
            {
                case 'f':
                    Console.WriteLine(length + "f is " + (int)(length * 0.3048) + "m");
                    break;
                case 'm':
                    Console.WriteLine(length + "m is " + (int)(length * 3.2808399) + "f");
                    break;
            }

            Console.ReadLine();
        }
    }
}
