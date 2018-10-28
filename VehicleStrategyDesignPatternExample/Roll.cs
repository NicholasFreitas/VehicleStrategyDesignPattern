using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategyDesignPatternExample
{
    class Roll : IMove
    {
        //Step_3
        /*
            Build concretion using the behavior abstraction 
        */
        public void Move() {

            Console.WriteLine("Rolls along.");
        }

    }
}
