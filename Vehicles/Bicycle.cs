using System;

namespace Vehicles
{
	public class Bicycle : IBrakeable, IHasWheels, ITwoWheeled
	{
		public void ActivateKickstand()
		{
			throw new NotImplementedException();
		}

		public void HitTheBrakes()
		{
			throw new NotImplementedException();
		}
	}
}
