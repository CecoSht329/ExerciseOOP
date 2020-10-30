
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (!this.Any())
            {
                return true;
            }
            return false;
        }

        public Stack<string> AddRange(string[] range)
        {
            foreach (string item in range)
            {
                this.Push(item);
            }
            return this;
        }
    }
}
