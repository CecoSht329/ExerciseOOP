
using System;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }

        public override string Name { get; protected set; }
        public override double Weight { get; protected set; }
        public override string LivingRegion { get; protected set; }
        public override int FoodEaten { get; protected set; }

        public override void Eat(Food food)
        {
            if ((food is Vegetable) || (food is Fruit))
            {
                FoodEaten += food.Quantity;
                this.Weight += (CommonValues.MouseAfterFood * food.Quantity);
            }
            else
            {
                string noneatable = food.GetType().ToString().Split(".")[1];
                throw new ArgumentException(string.Format(CommonValues.UnableToEatMessage, nameof(Mouse), noneatable));
            }
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
