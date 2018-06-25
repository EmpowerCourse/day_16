using System;

namespace VehiclesV2
{
    class Program
    {
        static void Main(string[] args)
        {
			var efficient = new FuelEfficientVehicle();
			var fast = new SuperFastVehicle();

			efficient.AddFuel(100);
			fast.AddFuel(100);

			efficient.Move();
			fast.Move();

			var truck = new Truck();
			

			// Exercise:
			//  Let's change MotorVehicle.Move() so that it returns a boolean declaring whether or not
			//  the move occurred.
			//  If the move is allowed, we will decrement fuel.
			//  If the move is not allowed, do not decrement fuel.
			//  Child classes (aka derived classes) will determine how many moves a given vehicle can make.
			//  Make sure to use the return value from the Move() method somewhere in Program.cs (Main).

        }
    }
}
