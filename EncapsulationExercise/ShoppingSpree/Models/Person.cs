using ShoppingSpree.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Messages.InvalidNameMessage);
                }
                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Messages.InvalidMoneyMessage);
                }
                money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
            => bag;

        public void BuyProduct(Product product)
        {
            if (product.Cost <= Money)
            {
                Money -= product.Cost;
                bag.Add(product);
                Console.WriteLine(string.Format(Messages.AbleToBuyMessage, Name, product.Name));
            }
            else
            {
                Console.WriteLine(string.Format(Messages.UnableToBuyMessage, Name, product.Name));
            }
        }
    }
}
