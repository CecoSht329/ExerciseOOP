
namespace BorderControl
{
    public class Citizen : INameable, IAgeable, IIdentifiable, IBirthable, IBuyer
    {
        public Citizen(string name, string age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Id { get; private set; }

        public string Birthday { get; private set; }

        public int Food
        {
            get
            {
                return 0;
            }
            private set
            {

            }
        }

        public int BuyFood()
        {
            return Food += 10;
        }
    }
}
