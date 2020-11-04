
using System;

namespace WildFarm
{
    public class Cat : Feline
    {
        private string name;
        private double weight;
        private string breed;
        private string livingRegion;

        public Cat(string name, double weight, string livingRegion, string breed)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
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
        public override string LivingRegion
        {
            get
            {
                return livingRegion;
            }
            protected set
            {
                livingRegion = value;
            }
        }
        public override string Breed
        {
            get
            {
                return breed;
            }
            protected set
            {
                breed = value;
            }
        }

        public override int FoodEaten { get; protected set; }

        public override void Eat(Food food)
        {
            if ((food is Vegetable) || (food is Meat))
            {
                FoodEaten += food.Quantity;
                Weight += (CommonValues.CatAfterFood * food.Quantity);
            }
            else
            {
                string noneatable = food.GetType().ToString().Split(".")[1];
                throw new ArgumentException(string.Format(CommonValues.UnableToEatMessage, nameof(Cat), noneatable));
            }
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
