using System;
namespace OopCatExercise
{
	public class LionCat:Cat
	{
        private string _setting = "wild";
        public override string Setting
        {
            get
            {
                return _setting;
            }
            set
            {
                _setting = value;
            }
        }
        private double _averageHeight = 1100;
        public override double AverageHeight
        {
            get
            {
                return _averageHeight;
            }
            set
            {
                _averageHeight = value;
            }
        }

        public override string Eat()
        {
            return "Roar!!!!";

        }
        public LionCat()
		{
		}
	}
}

