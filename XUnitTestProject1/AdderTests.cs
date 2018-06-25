using ClassLibrary1;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class AdderTests
    {
        [Fact]
        public void CalculatesCorrectly()
        {
			var adder = new Adder();
			adder.Add(1);
			adder.Add(2);
			var result = adder.Calculate();
			Assert.Equal(3, result);
		}
	}
}
