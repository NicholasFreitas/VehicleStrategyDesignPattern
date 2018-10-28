using System;

namespace VehicleStrategyDesignPatternExample
{
    /*
        My previous example wasn't perfect. Because it was using people and I was sort of injecting attributes.
        I wanted to preserve the spirit of the pattern, and it's purpose of injecting BEHAVIORS. So I have a simple example here
        for the demonstration of the different ways a vehicle can travel.

        CTRL+F Step_ to find all the steps.


             ----------------                    --------------
             | Vehicle      |                    |IMove       |
             |--------------|                    |------------| Abstraction
             | IMove        | <---- Has-A ------ |Move()      |
             |--------------|                    -------------- 
             | Move()       |                      ^         ^         
             ----------------                      |          |
                                                  Is-A       Is-A
                                               =========    ========                 
                                               |Roll   |    |Fly   |      
                                               |-------|    |------| Concretion (to be injected, see bellow)
                                               |Move() |    |Move()|
                                               =========    ========             
             


         */

    class Program
    {
        static void Main(string[] args)
        {
            //Step_4 instantiate client and inject behavior
            var automobile = new Vehicle(new Roll()); //<-- instantiate my client and then inject behavior
            
            automobile.Move(); // <-- call behavior

            var boat = new Vehicle(new Floats());

            boat.Move();

            var plane = new Vehicle(new Fly());

            plane.Move();

            Console.ReadLine();
        }
    }
}
