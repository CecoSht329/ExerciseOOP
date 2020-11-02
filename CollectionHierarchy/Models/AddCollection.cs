
using System.Collections.Generic;

namespace CollectionHierarchy
{
    public class AddCollection : IAddCollection
    {
        public AddCollection()
        {
            this.Collection = new List<string>();
        }

        public List<string> Collection { get; }

        public string Add(string item)
        {
            this.Collection.Add(item);
            return (Collection.Count-1).ToString();
        }
    }
}
