
namespace WildFarm
{
    public abstract class Mammal : Animal
    {
        public abstract string LivingRegion { get; protected set; }

        public override string ToString()
        {
            string mammalType = this.GetType().ToString().Split(".")[1];
            return $"{mammalType} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
