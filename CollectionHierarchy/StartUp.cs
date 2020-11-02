using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var items = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var removeActions = int.Parse(Console.ReadLine());

            var addCollectionResult = new List<string>();
            var addRemoveCollectionResult = new List<string>();
            var myListResult = new List<string>();

            foreach (var item in items)
            {
                addCollectionResult.Add(addCollection.Add(item));
                addRemoveCollectionResult.Add(addRemoveCollection.Add(item));
                myListResult.Add(myList.Add(item));
            }

            Console.WriteLine(string.Join(" ", addCollectionResult));
            Console.WriteLine(string.Join(" ", addRemoveCollectionResult));
            Console.WriteLine(string.Join(" ", myListResult));

            addRemoveCollectionResult.Clear();
            myListResult.Clear();

            for (int i = 0; i < removeActions; i++)
            {
                addRemoveCollectionResult.Add(addRemoveCollection.Remove());
                myListResult.Add(myList.Remove());
            }

            Console.WriteLine(string.Join(" ", addRemoveCollectionResult));
            Console.WriteLine(string.Join(" ", myListResult));
        }
    }
}
