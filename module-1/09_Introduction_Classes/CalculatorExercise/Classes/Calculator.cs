using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#### **Calculator**

//** Class Properties**

//| Property Name | Data Type | Get | Set | Description                               |
//| ------------- | --------- | --- | --- | ----------------------------------------- |
//| Result        | int       | X   |     | Holds the current value of the calculator |

//** Constructors**

//| Signature                      | Description                                                                            |
//| ------------------------------ | -------------------------------------------------------------------------------------- |
//| Calculator(int startingResult) | Starting value of the calculator.Initialize `Result` to the value of `startingResult` |

//** Methods**

//| Method Name              | Return Type | Description                                                                                                                     |
//| ------------------------ | ----------- | ------------------------------------------------------------------------------------------------------------------------------- |
//| Add(int addend)          | int         | Adds `addend` to `Result` and returns the current value of `Result`.                                                            |
//| Subtract(int subtrahend) | int         | Subtracts `subtrahend` from the current value of `Result` and returns the current value of `Result`.                            |
//| Multiply(int multiplier) | int         | Multiplies current result by `multiplier` and returns the current value of `Result`.                                            |
//| Power(int exponent)      | int         | Raises `Result` to power of `exponent`. Negative exponents should use the absolute value.Returns the current value of `Result` |
//| Reset()                  | void        | Resets `Result` to 0.                                                                                                           |



namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        public int Result { get; private set; }

        public Calculator(int startingResult)
        {
            Result = startingResult;
        }

        public int Add(int addend)
        {
            Result += addend;

            return Result;
        }

        public int Subtract(int subrahend)
        {
            Result -= subrahend;

            return Result;
        }

        public int Multiply (int multiplier)
        {
            Result *= multiplier;

            return Result;
        }

        public int Power(int exponent)
        {
            Result = (int)Math.Pow((double)Result, (double)Math.Abs(exponent));

            return Result;
        }

        public void Reset()
        {
            Result = 0;
        }
    }
}
