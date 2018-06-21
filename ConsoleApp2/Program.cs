using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
			var result = 0;
			foreach (var stringValue in args)
			{
				if (int.TryParse(stringValue, out int intValue))
				{
					result += intValue;
				}
			}

			Console.WriteLine(result.ToString());

			Console.ReadKey();
        }
    }
}
