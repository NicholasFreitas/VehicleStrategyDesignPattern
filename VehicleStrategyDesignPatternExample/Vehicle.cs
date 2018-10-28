using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategyDesignPatternExample
{
    class Vehicle
    {
        //Step_2
        /*
            Build client to be consume with the abstract behavior. 
        */
        IMove MovementType; //  <--- Abstract Behavior

        public Vehicle(IMove movementType) // <-- Inject the behavior through the constructor (this isn't the only way to do this)
        {
            MovementType = movementType;
        }

        public void Move() // <-- Method to call the abstracted Behavior.
        {
            MovementType.Move(); // <-- Behavior being called.
        }


    }
}
