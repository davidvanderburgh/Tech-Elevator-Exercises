using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#### **Company**

//** Class Properties**

//| Property Name     | Data Type | Get | Set | Description                    |
//| ----------------- | --------- | --- | --- | ------------------------------ |
//| Name              | string    | X   |     | Holds the name of the company. |
//| NumberOfEmployees | int       | X   | X   | Holds the number of employees. |
//| Revenue           | decimal   | X   | X   | Holds the company revenue.     |
//| Expenses          | decimal   | X   | X   | Holds the company expenses.    |

//**Constructors**

//| Signature                    | Description                                                                     |
//| ---------------------------- | ------------------------------------------------------------------------------- |
//| Company(string startingName) | Starting name of the company.This should set the value of the `Name` property. |

//**Methods**

//| Method Name      | Return Type | Description                                                                                                                     |
//| ---------------- | ----------- | ------------------------------------------------------------------------------------------------------------------------------- |
//| GetCompanySize() | string      | A company is "small" if less than 50 employees, "medium" if between 50 and 250 employees, "large" if greater than 250 employees |
//| GetProfit()      | decimal     | Calculated by subtracting expenses from revenue.                                                                                |



namespace TechElevator.Classes
{
    public class Company
    {
        public string Name { get; private set; }
        public int NumberOfEmployees { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }

        public Company(string startingName)
        {
            Name = startingName;
        }

        public string GetCompanySize()
        {
            if (NumberOfEmployees < 50)
            {
                return "small";
            }
            else if (NumberOfEmployees < 250)
            {
                return "medium";
            }
            else
            {
                return "large";
            }
        }

        public decimal GetProfit()
        {
            return (Revenue - Expenses);
        }

    }
}
