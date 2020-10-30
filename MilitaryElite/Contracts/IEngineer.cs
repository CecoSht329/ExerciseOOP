
using System.Collections.Generic;

namespace MilitaryElite
{
    public interface IEngineer
    {
        //holds a set of Repairs.
        public IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
