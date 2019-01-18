using System;

//The Fahrenheit to Celsius conversion formula is:

//    Tc = (Tf - 32) / 1.8

//where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit

//The Celsius to Fahrenheit conversion formula is:

//    Tf = Tc* 1.8 + 32

//Write a command line program which prompts a user to enter a temperature, and whether its in 
//degrees(C)elsius or(F)arenheit.Convert the temperature to the opposite degrees, and display the 
//old and new temperatures to the console.

//```
//Please enter the temperature: 58
//Is the temperature in (C) elcius, or (F) arenheit? F
//58F is 14C.
//```

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");
            int temperature = int.Parse(Console.ReadLine());

            Console.Write("Is the temperature in (C) elcius, or (F) ahrenheit? ");
            char celciusOrFahrenheit = char.Parse(Console.ReadLine());

            switch (celciusOrFahrenheit)
            {
                case 'C':
                    Console.WriteLine(temperature + "C is " + (int)(temperature * 1.8 + 32) + "F");
                    break;
                case 'F':
                    Console.WriteLine(temperature + "F is " + (int)((temperature - 32) / 1.8) + "C");
                    break;
            }

            Console.ReadLine();
        }
    }
}
