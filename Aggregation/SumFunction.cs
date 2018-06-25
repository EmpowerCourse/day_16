using System;
using System.Collections.Generic;

namespace Aggregation
{
	public class SumFunction : AggregateFunction
	{
		public override int Calculate()
		{
			var sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
			}
			return sum;
		}
	}
}
