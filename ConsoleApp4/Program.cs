using System;

namespace ConsoleApp4
{
    class Program
    {
		static void Main(string[] args)
		{
			var data = new string[]
			{
				"Apple",
				"Banana",
				null,
				"Cherry"
			};

			foreach (var item in data)
			{
				if (item == null)
				{
					Console.WriteLine("@");
				}
				else
				{
					Console.WriteLine(item);
				}
			}

			Console.ReadKey();

			// Print out ALL values in the data array,
			// unless they are null, in which case print
			// out a "@" in place of the null.

			// We should see (multiple lines):
			// Apple
			// Banana
			// @
			// Cherry

		}
    }
}
