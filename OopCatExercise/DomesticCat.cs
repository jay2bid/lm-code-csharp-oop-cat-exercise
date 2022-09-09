using System;
namespace OopCatExercise
{
	public class DomesticCat:Cat
	{
		private string _setting = "domestic";
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
        private double _averageHeight = 23;
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
            
            var random = new Random();
            bool willComment = random.Next(2) == 1;
            return willComment ? "Purrrrrrr" : "It will do I suppose";
        }
       
        public DomesticCat()
		{
		}
	}
}

