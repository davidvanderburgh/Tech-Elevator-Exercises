using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{

//    #### **Dog**

//** Class Properties**

//| Property Name | Data Type | Get | Set | Description                                                                        |
//| ------------- | --------- | --- | --- | ---------------------------------------------------------------------------------- |
//| IsSleeping    | bool      | X   |     | `TRUE` if the dog is asleep. `FALSE` if not. ** All new dogs are awake by default** |

//** Constructors**

//| Signature | Description                                                               |
//| --------- | ------------------------------------------------------------------------- |
//| Dog()     | Dog constructor takes no arguments. ** All new dogs are awake by default** |

//** Methods**

//| Method Name | Return Type | Description                                                                       |
//| ----------- | ----------- | --------------------------------------------------------------------------------- |
//| MakeSound() | string      | Returns `"Zzzzz..."` if the dog is asleep.Returns `"woof!"` if the dog is awake. |
//| Sleep()     | void        | Sets `IsSleeping` to `true`.                                                      |
//| WakeUp()    | void        | Sets `IsSleeping` to `false`.                                                     |


    /**
    * This class represents a dog that can sleep, wake, and make a sound, so it's pretty much like most dogs,
    * with a few essential methods missing. Thankfully.
    */
    public class Dog
    {
        
        public bool IsSleeping { get; private set; }

        public Dog()
        {
            IsSleeping = false;
        }

        public string MakeSound()
        {
            if (IsSleeping)
            {
                return "Zzzzz...";
            }
            else
            {
                return "woof!";
            }
        }

        public void Sleep()
        {
            IsSleeping = true;
        }

        public void WakeUp()
        {
            IsSleeping = false;
        }

    }
}
