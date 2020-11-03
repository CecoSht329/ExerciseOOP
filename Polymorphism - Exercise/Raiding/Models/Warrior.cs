
namespace Raiding
{
    public class Warrior : BaseHero
    {
        private string name;
        private readonly int power;
        private const int warriorPower = 100;
        public Warrior(string name)
        {
            this.name = name;
            power = warriorPower;
        }
        public override string Name
            => name;

        public override int Power
            => power;
        public override string CastAbility()
        {
            return $"{nameof(Warrior)} - {Name} hit for {Power} damage";
        }
    }
}
