using System;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string tomcatGender = "Male";
        public Tomcat(string name, int age)
            : base(name, age, tomcatGender)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
