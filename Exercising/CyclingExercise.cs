using System;

namespace Exercising
{
    public class CyclingExercise : ExerciseProcess
    {
        protected override void Exercise()
        {
            Console.WriteLine("Pedal really hard.");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Pump up tires.");
        }

        protected override void Finish()
        {
            Console.WriteLine("Lower kickstand.");
            base.Finish();
        }
    }
}
