using System;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

			var value1 = "One";
			var value2 = "Two";

			var value4 = $"{value1}{value2}";

			var sb = new StringBuilder();
			sb.Append(value1);
			sb.Append(value2);
			var value5 = sb.ToString();

			Console.WriteLine(value4);
			Console.WriteLine(value5);

			//var sb = new StringBuilder();
			//foreach (var item in args)
			//{
			//	sb.Append(item);
			//}
			//var myString = sb.ToString();


			Console.ReadKey();
        }
    }
}
