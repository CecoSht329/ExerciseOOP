
using CollectionHierarchy.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CollectionHierarchy
{
    public class MyList : IMyList
    {
        public MyList()
        {
            Collection = new List<string>();
        }
        public List<string> Collection { get; }

        public int Used
            => this.Collection.Count;

        public string Add(string item)
        {
            this.Collection.Insert(0, item);
            return "0";
        }

        public string Remove()
        {
            var firstElement = this.Collection.First();
            this.Collection.Remove(firstElement);

            return firstElement;
        }
    }
}
