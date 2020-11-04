
using System.Dynamic;

namespace WildFarm
{
    public class Hen : Bird
    {
        private string name;
        private double weight;
        private double wingSize;
        public Hen(string name, double weight, double wingSize)
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
            FoodEaten += food.Quantity;
            this.Weight += (CommonValues.HenAfterFood * food.Quantity);
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
