

namespace WildFarm
{
    public abstract class Bird : Animal
    {
        public abstract double WingSize { get; protected set; }

        public override string ToString()
        {
            string birdType = this.GetType().ToString().Split(".")[1];
            return $"{birdType} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
