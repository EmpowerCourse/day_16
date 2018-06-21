using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {


			foreach (var dateString in args)
			{
				var date = DateTime.Parse(dateString);
				date = date.AddMonths(6);
				Console.WriteLine(date.ToString("MM^yyyy"));
			}




			Console.ReadKey();
        }
    }
}
