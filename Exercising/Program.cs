using System;

namespace Exercising
{
    class Program
    {
        static void Main(string[] args)
        {
            var swimming = new SwimmingExercise();
            var walking = new WalkingExercise();
            var cycling = new CyclingExercise();

            swimming.Go();
            walking.Go();
            cycling.Go();

            Console.ReadKey();
        }
    }
}
