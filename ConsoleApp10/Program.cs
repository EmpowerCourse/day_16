using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

			var spot = new Animal("Spot", 5);

			var gary = new Animal("Gary", 15);


            Console.WriteLine(spot.GetSpeech());
			Console.WriteLine(gary.GetSpeech());
			Console.ReadKey();
        }
    }
}
