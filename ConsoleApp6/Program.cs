using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
			// Inputs will be integers, from command line, and there will
			// be some bad (i.e. non-integer) values.
			// Bad values will be ignored.
			// The output will be a list of all values, with a description
			// of the number (e.g. "1(ODD)", and "2(EVEN)").
			// The numbers 3, 7, and 13 are special (e.g. "7(SPECIAL)").
			// Numbers over 100 are ignored (just like invalid values).
			// Example input:
			// 1 2 3 4 giraffe 5 1008 1009 6 zebra
			// Expected output (multiple lines):
			// 1(ODD) 2(EVEN) 3(SPECIAL) 4(EVEN) 5(ODD) 6(EVEN)
			// BONUS:
			// A final line that has the TOTAL of all INCLUDED values (21).

			var total = 0;
			foreach (var arg in args)
			{
				if (int.TryParse(arg, out int value) && value <= 100)
				{
					total += value;
					var isSpecial = value == 3 || value == 7 || value == 13;
					//switch (value)
					//{
					//	case 3:
					//	case 7:
					//	case 13:
					//		isSpecial = true;
					//		break;
					//}
					var isEven = value % 2 == 0;
					var description = String.Empty;
					if (isSpecial)
					{
						description = "SPECIAL";
					}
					else
					{
						description = isEven ? "EVEN" : "ODD";
						//if (isEven)
						//{
						//	description = "EVEN";
						//}
						//else
						//{
						//	description = "ODD";
						//}
					}
					Console.WriteLine($"{value}({description})");
				}
			}
			Console.WriteLine(total.ToString());
			Console.ReadKey();
        }
    }
}
