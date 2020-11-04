
namespace WildFarm
{
    public abstract class Feline : Mammal
    {
        public abstract string Breed { get; protected set; }

        public override string ToString()
        {
            string felineType = this.GetType().ToString().Split(".")[1];
            return $"{felineType} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
