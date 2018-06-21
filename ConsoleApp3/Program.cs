using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
			var firstNumber = int.Parse(args[0]);
			var secondNumber = int.Parse(args[1]);
			var result = firstNumber + secondNumber;
			Console.WriteLine(result.ToString());
			Console.ReadKey();
		}
	}
}
