using System;

namespace ConsoleApp10
{
	public class Animal
	{
		private readonly string name;
		private readonly int age;

		public Animal(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public string GetSpeech()
		{
			return $"Bark!  My name is {name}, and I'm {age} years old!";
		}
	}
}
