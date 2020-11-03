
namespace Raiding
{
    public class Paladin : BaseHero
    {
        private string name;
        private readonly int power;
        private const int paladinPower = 100;
        public Paladin(string name)
        {
            this.name = name;
            power = paladinPower;
        }
        public override string Name
            => name;

        public override int Power
            => power;

        public override string CastAbility()
        {
            return $"{nameof(Paladin)} - {Name} healed for {Power}";
        }
    }
}
