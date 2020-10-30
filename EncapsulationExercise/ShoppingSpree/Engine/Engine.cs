using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Engine
    {
        public void Run()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInfo = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (string personInfo in peopleInfo)
            {
                string[] currentPersonInfo = personInfo
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = currentPersonInfo[0];
                decimal money = decimal.Parse(currentPersonInfo[1]);
                Person person = new Person(name, money);
                people.Add(person);
            }

            string[] productsInfo = Console.ReadLine()
               .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (string productInfo in productsInfo)
            {
                string[] currentProductInfo = productInfo
                    .Split("=");
                string name = currentProductInfo[0];
                decimal money = decimal.Parse(currentProductInfo[1]);
                Product product = new Product(name, money);
                products.Add(product);
            }

            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                string[] currentPurchase = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentPersonName = currentPurchase[0];
                string currentProductName = currentPurchase[1];

                Person currentPerson = people.FirstOrDefault(p => p.Name == currentPersonName);
                Product productToPurchase = products.FirstOrDefault(p => p.Name == currentProductName);

                currentPerson.BuyProduct(productToPurchase);
            }

            foreach (Person person in people)
            {
                string currentBag = person.Bag.Count > 0 ? $"{string.Join(", ", person.Bag.Select(p => p.Name))}"
                    : "Nothing bought";
                Console.WriteLine($"{person.Name} - {currentBag}");
            }
        }
    }
}
