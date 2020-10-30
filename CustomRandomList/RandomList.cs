using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random randomIndex = new Random();

            int index = randomIndex.Next(0, this.Count - 1);
            string result = this[index];
            this.Remove(this[index]);
            return result;
        }
    }
}
