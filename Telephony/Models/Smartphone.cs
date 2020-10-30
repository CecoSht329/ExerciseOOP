
using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public void Browse(string site)
        {
            if (site.Any(char.IsDigit))
            {
                throw new Exception("Invalid URL!");
            }
            Console.WriteLine($"Browsing: {site}!");
        }

        public void Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                throw new Exception("Invalid number!");
            }
            Console.WriteLine($"Calling... {number}");
        }
    }
}
