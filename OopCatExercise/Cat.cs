using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
        public bool IsAsleep = false;
        public abstract string Setting { get; set; }
        public abstract double AverageHeight { get; set; }

        public void GoToSleep()
        {
            IsAsleep = true;
        }
        public void WakeUp()
        {
            IsAsleep = false;
        }

        public abstract string Eat();
    }
}
