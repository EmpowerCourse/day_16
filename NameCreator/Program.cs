using System;

namespace NameCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> getFullName = (fname, lname) =>
            {
                return $"{lname}, {fname}";
            };

            Console.WriteLine("Please enter the first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name:");
            var lastName = Console.ReadLine();

            var fullName = getFullName(firstName, lastName);

            Console.WriteLine("Full name:");
            Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}
