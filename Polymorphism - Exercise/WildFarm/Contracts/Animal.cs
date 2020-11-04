

namespace WildFarm
{
    public abstract class Animal
    {
        //•	Animal – string Name, double Weight, int FoodEaten;
        public abstract string Name { get; protected set; }
        public abstract double Weight { get; protected set; }
        public abstract int FoodEaten { get; protected set; }

        public abstract string ProduceSound();

        public abstract void Eat(Food food);
    }
}
