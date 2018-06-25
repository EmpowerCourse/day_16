using System;

namespace Vehicles
{
	public class Car : IBrakeable, IHasWheels, IHasPassengers, IMotored
	{
		public void HitTheBrakes()
		{
			throw new NotImplementedException();
		}
	}
}
