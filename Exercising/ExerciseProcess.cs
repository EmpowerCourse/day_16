using System;

namespace Exercising
{
    public abstract class ExerciseProcess
    {
        protected abstract void Prepare();
        protected abstract void Exercise();

        protected virtual void Finish()
        {
            Console.WriteLine("Shower.");
        }

        public void Go()
        {
            Prepare();
            Exercise();
            Finish();
        }
    }
}
