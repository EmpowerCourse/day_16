using System;

namespace ConsoleApp12
{
	public class OatmealCookProcess : CookProcess
	{
		protected override void ApplyFoodToCooker()
		{
			Console.WriteLine("Putting oatmeal in microwave.");
		}

		protected override void TurnOffCooker()
		{
			Console.WriteLine("Turning off microwave for oatmeal!");
		}

		protected override void TurnOnCooker()
		{
			Console.WriteLine("Turning on microwave for oatmeal!");
		}
	}
}
