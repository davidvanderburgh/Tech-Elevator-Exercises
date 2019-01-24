using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#### **Person**

//** Class Properties**

//| Property Name | Data Type | Get | Set | Description                         |
//| ------------- | --------- | --- | --- | ----------------------------------- |
//| FirstName     | string    | X   | X   | Holds the first name of the person. |
//| LastName      | string    | X   | X   | Holds the last name of the person.  |
//| Age           | int       | X   | X   | Holds the age of the person.        |

//**Methods**

//| Method Name   | Return Type | Description                                       |
//| ------------- | ----------- | ------------------------------------------------- |
//| GetFullName() | string      | Returns the First Name + Last Name of the Person. |
//| IsAdult()     | bool        | Returns `true` if the person is 18 or older.      |

namespace TechElevator.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public bool IsAdult()
        {
            return (Age >= 18);
        }


    }
}
