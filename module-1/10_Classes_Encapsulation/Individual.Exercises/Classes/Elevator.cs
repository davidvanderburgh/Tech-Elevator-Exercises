using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; }
        public int NumberOfLevels { get; }
        public bool DoorIsOpen { get; private set; }

        public Elevator(int numberOfLevels)
        {
            if (numberOfLevels > 0)
            {
                NumberOfLevels = numberOfLevels;
                CurrentLevel = 1;
            }
        }


        //- `OpenDoor()` opens the elevator door.
        public void OpenDoor()
        {
            DoorIsOpen = true;
        }

        //- `CloseDoor()` closes the elevator door.
        public void CloseDoor()
        {
            DoorIsOpen = false;
        }

        //- `GoUp(int desiredFloor)` sends the elevator upward to the desired floor as long as the door is not open. Cannot go past last floor.
        public void GoUp(int desiredFloor)
        {
            if ((desiredFloor > CurrentLevel) && 
                (desiredFloor <= NumberOfLevels) && 
                !DoorIsOpen)
            {
                CurrentLevel = desiredFloor;
            }
        }

        //- `GoDown(int desiredFloor)` sends the elevator downward to the desired floor as long as the door is not open. Cannot go past floor 1.
        public void GoDown(int desiredFloor)
        {
            if ((desiredFloor < CurrentLevel) &&
                (desiredFloor >= 1) && 
                !DoorIsOpen)
            {
                CurrentLevel = desiredFloor;
            }
        }
    }
}
