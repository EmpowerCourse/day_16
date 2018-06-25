using System;

namespace VehiclesV2
{
	public class FuelEfficientVehicle : MotorVehicle
	{
		protected override int CalculateFuelDepletion()
		{
			return 1;
		}
	}
}
