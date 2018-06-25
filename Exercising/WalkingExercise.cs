using System;

namespace Exercising
{
    public class WalkingExercise : ExerciseProcess
    {
        protected override void Exercise()
        {
            Console.WriteLine("Walk to the store and back.");
        }

        protected override void Prepare()
        {
        }
    }
}
