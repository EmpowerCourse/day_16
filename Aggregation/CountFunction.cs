using System;

namespace Aggregation
{
	public class CountFunction : AggregateFunction
	{
		public override int Calculate()
		{
			return numbers.Count;
		}
	}
}
