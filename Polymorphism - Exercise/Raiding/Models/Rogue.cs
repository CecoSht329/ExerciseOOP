
namespace Raiding
{
    public class Rogue : BaseHero
    {
        private string name;
        private readonly int power;
        private const int roguePower = 80;
        public Rogue(string name)
        {
            this.name = name;
            power = roguePower;
        }
        public override string Name
            => name;

        public override int Power
            => power;

        public override string CastAbility()
        {
            return $"{nameof(Rogue)} - {Name} hit for {Power} damage";
        }
    }
}
