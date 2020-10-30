
namespace MilitaryElite
{
    public interface IRepair
    {
        //A Repair holds a part name and hours worked(int).
        public string PartName { get; }
        public int HoursWorked { get; }
    }
}
