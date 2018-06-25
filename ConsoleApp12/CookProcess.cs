using System;

namespace ConsoleApp12
{
	public abstract class CookProcess : ICookable
	{
		protected abstract void TurnOnCooker();
		protected abstract void ApplyFoodToCooker();
		protected abstract void TurnOffCooker();

		public void Cook()
		{
			TurnOnCooker();
			ApplyFoodToCooker();
			// Lots more code
			TurnOffCooker();
		}
	}
}
