using System;
using System.Collections.Generic;

namespace Aggregation
{
	public abstract class AggregateFunction : IAggregateFunction
	{
		protected readonly List<int> numbers = new List<int>();
		public abstract int Calculate();

		public void Insert(int value)
		{
			numbers.Add(value);
		}
	}
}
