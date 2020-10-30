
namespace MilitaryElite
{
    public interface ISpecialisedSoldier
    {
        //general class for all specialised Soldiers - holds the corps of the Soldier.
        //    The corps can only be one of the following: Airforces or Marines.
        public string Corps { get; }
    }
}
