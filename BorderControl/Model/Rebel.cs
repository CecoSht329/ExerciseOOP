
using BorderControl.Contracts;

namespace BorderControl
{
    public class Rebel : INameable, IAgeable, IGroupable, IBuyer
    {
        public Rebel(string name, string age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Group { get; private set; }

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
            return Food += 5;
        }
    }
}
