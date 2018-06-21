using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
			var adder = new Adder();
			foreach (var arg in args)
			{
				var value = int.Parse(arg);
				adder.Add(value);
			}
			Console.WriteLine(adder.Calculate());
			Console.ReadKey();
        }
    }
}
