using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStrategyDesignPatternExample
{
    class Fly : IMove
    {
        public void Move()
        {
            Console.WriteLine("Flies along.");
        }
    }
}
