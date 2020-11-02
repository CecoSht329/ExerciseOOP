
namespace ExplicitInterfaces
{
    class Citizen : IPerson, IResident
    {
        public Citizen(string name, string age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name { get; private set; }
        public string Country { get; private set; }
        public string Age { get; private set; }

    }
}
