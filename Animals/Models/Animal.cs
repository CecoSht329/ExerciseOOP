using Animals.Common;
using System;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }




        public string Name
        {
            get => name;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException(Message.ArgumentExceptionMessage);
                }
            }
        }
        public int Age
        {
            get => age;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Message.ArgumentExceptionMessage);
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Gender
        {
            get => gender;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException(Message.ArgumentExceptionMessage);
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType()}");
            sb.AppendLine($"{Name} {Age} {Gender}");
            return sb.ToString().Trim();
        }
        public abstract string ProduceSound();
    }
}
