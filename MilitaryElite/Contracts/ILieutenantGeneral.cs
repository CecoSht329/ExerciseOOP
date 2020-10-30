using System.Collections.Generic;

namespace MilitaryElite
{
    public interface ILieutenantGeneral
    {
        public IReadOnlyCollection<ISoldier> Soldiers { get;  }
    }
}
