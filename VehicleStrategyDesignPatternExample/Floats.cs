using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategyDesignPatternExample
{
    class Floats : IMove
    {
        public void Move()
        {
            Console.WriteLine("Floats along.");
        }
    }
}
