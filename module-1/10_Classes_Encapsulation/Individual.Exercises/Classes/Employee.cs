using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        //### Employee

        //#### Properties

        //| Property     | Data Type | Get | Set      | Description                             |
        //| ------------ | --------- | --- | -------- | --------------------------------------- |
        //| EmployeeId   | int       | X   | readonly | Gets the employee id.                   |
        //| FirstName    | string    | X   | readonly | Gets the employee's first name.         |
        //| LastName     | string    | X   | X        | Gets or sets the employee's last name.  |
        //| FullName     | string    | X   |          | Gets the employee's full name.          |
        //| Department   | string    | X   | X        | Gets or sets the employee's department. |
        //| AnnualSalary | double    | X   | private  | Gets the employee's annual salary.      |

        public int EmployeeId { get; }
        public string FirstName { get; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public string Department { get; set; }
        public double AnnualSalary { get; private set; }

        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = salary;
        }

        public void RaiseSalary(double percent)
        {
            if (percent >= 0.0)
            {
                AnnualSalary *= 1 + (percent / 100.0);
            }
        }

        //#### Methods

        //`public void RaiseSalary(double percent)`

        //**Notes**

        //- `RaiseSalary(double percent)` increases the current annual salary by the percentage provided(e.g. 5.5 represents 5.5%)

    }
}
