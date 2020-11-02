
using CollectionHierarchy.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        public AddRemoveCollection()
        {
            this.Collection = new List<string>();
        }
        public List<string> Collection { get; }

        public string Add(string item)
        {
            this.Collection.Insert(0, item);
            return "0";
        }

        public string Remove()
        {
            var lastItem = this.Collection.Last();
            this.Collection.Remove(lastItem);

            return lastItem;
        }
    }
}
