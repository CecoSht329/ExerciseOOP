
using System;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }

        public override string Name
        {
            get;
            protected set;
        }
        public override double Weight
        {
            get;
            protected set;
        }

        public override string LivingRegion
        {
            get;
            protected set;
        }
        public override int FoodEaten { get; protected set; }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += (CommonValues.DogAfterFood * food.Quantity);
            }
            else
            {
                string noneatable = food.GetType().ToString().Split(".")[1];
                throw new ArgumentException(string.Format(CommonValues.UnableToEatMessage, nameof(Dog), noneatable));
            }
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
