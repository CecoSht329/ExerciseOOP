using System;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public void Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                throw new Exception("Invalid number!");
            }
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
