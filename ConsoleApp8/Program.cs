using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
			// New NameProcessor class.
			// Holds names of people (first names are all we need)
			// The class fixes capitalization of first name (i.e. it turns "bob" into "Bob")
			// Class has two methods:  Add and GetNamesStartingWith
			// Calling code can fill the process up with as many names at it wishes.
			// The GetNamesStartingWith will return all names it knows about that start with a given string parameter.
			// Be sure to show an example of the code working (i.e. being called from Main).

			var nameProcessor = new NameProcessor();
			nameProcessor.Add("bob");
			nameProcessor.Add("Alice");
			nameProcessor.Add("Bobby");
			nameProcessor.Add("alina");

			var bobs = nameProcessor.GetNamesStartingWith("Bob");
			var alis = nameProcessor.GetNamesStartingWith("Ali");
			var charlies = nameProcessor.GetNamesStartingWith("Charlie");

		}
	}
}
