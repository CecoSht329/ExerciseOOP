
using System.Collections.Generic;

namespace CollectionHierarchy
{
    public interface IAddCollection
    {
        List<string> Collection { get; }

        public string Add(string item);
    }
}
