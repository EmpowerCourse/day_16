using System;

namespace VehiclesV2
{
	public class Truck : MotorVehicle
	{
		protected override int CalculateFuelDepletion()
		{
			return 2;
		}
	}
}
