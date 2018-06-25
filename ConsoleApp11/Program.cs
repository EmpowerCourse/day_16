using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
			var bob = new Person();
			var alice = new Person();
			bob.Name = "Bob";
			bob.Age = 30;
			alice.Name = "Alice";
			alice.Age = 25;


			var person1 = bob;
			var person2 = bob;
			var person3 = bob;
			var person4 = bob;
			var person5 = bob;


			person1.Name = "Bobby";
			person4.Age++;



			Person david;

			david = new Person();

			david = bob;

			david = new Person();




			//var charlie = new Person();
			//charlie.Name = "Charlie";
			//charlie.Age = 55;
			//charlie = alice;
			//charlie.Age = 88;

			//////////////////////////////////////

			//var value1 = 10;
			//var value2 = 20;
			//var value3 = value2;

			//value3 = 5000;



			//Console.WriteLine("Hello World!");
		}
    }
}
