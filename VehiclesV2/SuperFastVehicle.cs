using System;

namespace VehiclesV2
{
	public class SuperFastVehicle : MotorVehicle
	{
		protected override int CalculateFuelDepletion()
		{
			return 45;
		}
	}
}
