using System;

namespace ExceptionsExamples
{
    public class Person
    {
        public int Age { get; }

        public Person(int age)
        {
            if (age < 0) throw new InvalidAgeException();
            Age = age;
        }
    }
}
