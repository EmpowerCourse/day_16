using System;

namespace Automobiles
{
	public class SportsCar : IMotorVehicle
	{
		private int cargo;

		public bool AddCargo(int cargoToAdd)
		{
			if (cargoToAdd > 100) return false;
			cargo = cargoToAdd;
			return true;
		}

		public void MoveForOneHour()
		{
			// Empty
		}

		public int GetDistanceTravelled()
		{
			return 0;
		}
	}
}
