using System;

namespace AutomobilesApp
{
	public class PickupTruck : IMotorVehicle
	{
		public void Go()
		{
			Console.WriteLine("I can carry lots of heavy stuff!");
		}
	}
}
