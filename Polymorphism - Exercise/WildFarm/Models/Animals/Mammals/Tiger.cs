
using System;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }

        public override string Name { get; protected set; }
        public override double Weight { get; protected set; }
        public override string LivingRegion { get; protected set; }
        public override string Breed { get; protected set; }
        public override int FoodEaten { get; protected set; }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += (CommonValues.TigerAfterFood * food.Quantity);
            }
            else
            {
                string noneatable = food.GetType().ToString().Split(".")[1];
                throw new ArgumentException(string.Format(CommonValues.UnableToEatMessage, nameof(Tiger), noneatable));
            }
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
