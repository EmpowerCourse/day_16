using System;
using System.Collections.Generic;

namespace AutomobilesApp
{
    class Program
    {
        static void Main(string[] args)
        {
			var motorVehicles = new List<IMotorVehicle>();
			motorVehicles.Add(new SportsCar());
			motorVehicles.Add(new SportsCar());
			motorVehicles.Add(new PickupTruck());
			motorVehicles.Add(new PickupTruck());

			foreach (var motorVehicle in motorVehicles)
			{
				motorVehicle.Go();
			}




			//var sc = new SportsCar();
			//var pu = new PickupTruck();
			//var mv = (IMotorVehicle)sc;

			


			Console.ReadKey();
        }
    }
}
