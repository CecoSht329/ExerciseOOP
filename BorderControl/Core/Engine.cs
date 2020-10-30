
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace BorderControl
{
    public class Engine
    {
        public void Run()
        {
            Dictionary<INameable, IBuyer> buyers = new Dictionary<INameable, IBuyer>();

            int peopleCount = int.Parse(Console.ReadLine());
            for (int person = 0; person < peopleCount; person++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                string age = personInfo[1];
                if (personInfo.Length == 3)//rebel
                {
                    //Stancho 27 WildMonkeys

                    string group = personInfo[2];
                    Rebel rebel = new Rebel(name, age, group);
                    buyers.Add(rebel, rebel);
                }
                else if (personInfo.Length == 4)//citizen
                {
                    //Pesho 25 8904041303 04/04/1989
                    string id = personInfo[2];
                    string birthday = personInfo[3];
                    Citizen citizen = new Citizen(name, age, id, birthday);
                    buyers.Add(citizen, citizen);
                }
            }

            int totalFoodPurchased = 0;
            string buyerName = "";
            while ((buyerName = Console.ReadLine()) != "End")
            {
                if (buyers.Any(x => x.Key.Name == buyerName))
                {
                    totalFoodPurchased += buyers.FirstOrDefault(x => x.Key.Name == buyerName).Value.BuyFood();
                }
            }
            Console.WriteLine(totalFoodPurchased);
        }
    }
}
