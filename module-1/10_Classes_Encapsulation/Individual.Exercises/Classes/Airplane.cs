using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//### Airplane

//#### Properties

//| Property                 | Data Type | Get | Set      | Description                                         |
//| ------------------------ | --------- | --- | -------- | --------------------------------------------------- |
//| PlaneNumber              | string    | X   | readonly | Gets the six-character plane number.                |
//| BookedFirstClassSeats    | int       | X   | private  | Gets the number of already booked first class seats |
//| AvailableFirstClassSeats | int       | X   |          | Gets the number of available first class seats.     |
//| TotalFirstClassSeats     | int       | X   | readonly | Gets the number of total first class seats.         |
//| BookedCoachSeats         | int       | X   | private  | Gets the number of already booked coach seats       |
//| AvailableCoachSeats      | int       | X   |          | Gets the number of available coach seats.           |
//| TotalCoachSeats          | int       | X   | readonly | Gets the number of total coach seats.               |

//** Notes**

//- `AvailableFirstClassSeats` is a derived property calculated by subtracting `BookedFirstClassSeats` from `TotalFirstClassSeats`
//- `AvailableCoachSeats` is a derived property calculated by subtracting `BookedCoachSeats` from `TotalCoachSeats`

//#### Constructors

//The `Airplane` class has a single constructor.It accepts two arguments.

//    `Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)`

//- `planeNumber` is the assigned plane number to the airplane.
//- `totalFirstClassSeats` is the initial number of total first class seats.
//- `totalCoachSeats` is the initial number of total coach seats.

//#### Methods

//`bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)`

//** Notes**

//- `ReserveSeats()` is a method
//  - if forFirstClass is true, add `totalNumberOfSeats` to the value for `BookedFirstClassSeats`
//  - if forFirstClass is false, add `totalNumberOfSeats` to the value for `BookedCoachSeats`
//  - return `true` if there were enough seats to make the reservation


namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        public string PlaneNumber { get; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalFirstClassSeats { get; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }
        public int TotalCoachSeats { get; }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }

        //#### Methods

        //`bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)`

        //** Notes**

        //- `ReserveSeats()` is a method
        //  - if forFirstClass is true, add `totalNumberOfSeats` to the value for `BookedFirstClassSeats`
        //  - if forFirstClass is false, add `totalNumberOfSeats` to the value for `BookedCoachSeats`
        //  - return `true` if there were enough seats to make the reservation

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass)
            {
                if (AvailableFirstClassSeats - totalNumberOfSeats > 0)
                {
                    BookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (AvailableCoachSeats - totalNumberOfSeats > 0)
                {
                    BookedCoachSeats += totalNumberOfSeats;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
