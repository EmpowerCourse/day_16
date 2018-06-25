using System;
using System.Collections.Generic;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
			// Exercise:
			// A new interface, IAggregate (or IAggregateFunction)
			//   Interface contains two methods:  void Insert(int value), and int Calculate()
			// Write TWO new classes:  Sum, and Average
			// Both classes implement the interface, but each does different math
			// From some calling code, use both classes via their interfaces.
			//   (For example, a loop over a list that contains one of each aggregate type)
			//   You may also get creative and create a new method that takes a parameter that is
			//   of the interface type (as opposed to a loop).
			//   Any usage of the classes via their interface is a success!

			//  (For clarity, this line has been replaced above.  The "Add" was changed to "Insert".)
			//   Interface contains two methods:  void Add(int value), and int Calculate()

			//var sumFunction = new SumFunction();
			//sumFunction.Insert(4);
			//sumFunction.Insert(4);
			//Console.WriteLine(sumFunction.Calculate());

			//var averageFunction = new AverageFunction();
			//averageFunction.Insert(4);
			//averageFunction.Insert(4);
			//Console.WriteLine(averageFunction.Calculate());


			var numbers = new List<int>();
			foreach (var arg in args)
			{
				numbers.Add(int.Parse(arg));
			}

			var function = new CountFunction();

			Execute(function, numbers);

			Console.ReadKey();

			

		}

		static void Execute(IAggregateFunction function, List<int> numbers)
		{
			foreach (var number in numbers)
			{
				function.Insert(number);
			}
			Console.WriteLine(function.Calculate());
		}
	}
}
