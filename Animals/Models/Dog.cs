using System;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
