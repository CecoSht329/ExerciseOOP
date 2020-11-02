
namespace ExplicitInterfaces
{
    public interface IPerson
    {
        //name, an age and a method GetName(). 
        public string Name { get; }
        public string Age { get; }

        public string GetName()
        {
            return Name;
        }
    }
}
