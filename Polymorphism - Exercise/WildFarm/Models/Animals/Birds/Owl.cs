
using System;

namespace WildFarm
{
    public class Owl : Bird
    {
        private string name;
        private double weight;
        private double wingSize;
        public Owl(string name, double weight, double wingSize)
        {
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }
        public override string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }
        public override double Weight
        {
            get
            {
                return weight;
            }
            protected set
            {
                weight = value;
            }
        }
        public override double WingSize
        {
            get
            {
                return wingSize;
            }
            protected set
            {
                wingSize = value;
            }
        }

        public override int FoodEaten { get; protected set; }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += (CommonValues.OwlAfterFood * food.Quantity);
            }
            else
            {
                string noneatable = food.GetType().ToString().Split(".")[1];
                throw new ArgumentException(string.Format(CommonValues.UnableToEatMessage, nameof(Owl), noneatable));
            }
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
