using System;

namespace ExceptionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bob = new Person(20);
                var alice = new Person(-12);
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("There was a problem creating the person objects.");
                throw;
            }
            catch (ArgumentException)
            {
                // Handle here
            }
            finally
            {
                Console.WriteLine("FINALLY.");
            }
            Console.ReadKey();
        }
    }
}
