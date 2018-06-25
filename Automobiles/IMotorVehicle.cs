using System;

namespace Automobiles
{
    public interface IMotorVehicle
    {
		bool AddCargo(int cargoToAdd);
		void MoveForOneHour();
		int GetDistanceTravelled();
	}
}
