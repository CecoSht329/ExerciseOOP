using System;
using System.Linq;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var numbersToDial = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var urlsToBrowse = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var smartphone = new Smartphone();
            var stationaryPhone = new StationaryPhone();
            foreach (string number in numbersToDial)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        stationaryPhone.Call(number);
                    }
                    else if (number.Length == 10)
                    {
                        smartphone.Call(number);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            foreach (string site in urlsToBrowse)
            {
                try
                {
                    smartphone.Browse(site);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
