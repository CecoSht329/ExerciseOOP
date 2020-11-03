
namespace Raiding
{
    public class Druid : BaseHero
    {
        private string name;
        private readonly int power;
        private const int druidPower = 80;
        public Druid(string name)
        {
            this.name = name;
            this.power = druidPower;
        }
        public override string Name
            => name;
        public override int Power
            => power;

        public override string CastAbility()
        {
            return $"{nameof(Druid)} - {Name} healed for {Power}";
        }
    }
}
