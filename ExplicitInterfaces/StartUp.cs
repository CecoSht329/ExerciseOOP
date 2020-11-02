using System;

namespace ExplicitInterfaces
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //PeshoPeshev Bulgaria 20
                string name = tokens[0];
                string country = tokens[1];
                string age = tokens[2];
                IPerson person = new Citizen(name, age, country);
                IResident personAsResident = new Citizen(name, age, country);
                Console.WriteLine(person.GetName());
                Console.WriteLine(personAsResident.GetName());
            }
        }
    }
}
