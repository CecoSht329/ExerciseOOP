
using System.Collections.Generic;

namespace MilitaryElite
{
    public interface ICommando
    {
        //holds a set of Missions
        public IReadOnlyCollection<IMission> Missions { get; }
    }
}
