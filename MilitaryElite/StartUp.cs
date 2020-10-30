using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var privates = new List<Private>();
            var input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                var soldierInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var id = soldierInfo[1];
                var firstName = soldierInfo[2];
                var lastName = soldierInfo[3];

                if (input.StartsWith("Private"))
                {
                    var salary = decimal.Parse(soldierInfo[4]);
                    var @private = new Private(id, firstName, lastName, salary);
                    Console.WriteLine(@private.ToString());
                    privates.Add(@private);
                }
                else if (input.StartsWith("LieutenantGeneral"))
                {
                    var salary = decimal.Parse(soldierInfo[4]);
                    var lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
                    for (int index = 5; index < soldierInfo.Length; index++)
                    {
                        string currentPrivateId = soldierInfo[index];
                        lieutenantGeneral.AddSoldier(privates, currentPrivateId);
                    }
                    Console.WriteLine(lieutenantGeneral.ToString());
                }
                else if (input.StartsWith("Engineer"))
                {
                    var salary = decimal.Parse(soldierInfo[4]);
                    var corps = soldierInfo[5];
                    var engineer = new Engineer(id, firstName, lastName, salary, corps);
                    var partName = "";
                    var hoursWorked = 0;
                    for (int index = 6; index < soldierInfo.Length; index++)
                    {
                        if (index % 2 == 0)
                        {
                            partName = soldierInfo[index];
                        }
                        else
                        {
                            hoursWorked = int.Parse(soldierInfo[index]);
                            var repair = new Repair(partName, hoursWorked);
                            engineer.AddRepair(repair);
                        }
                    }
                    Console.WriteLine(engineer.ToString());
                }
                else if (input.StartsWith("Commando"))
                {
                    var salary = decimal.Parse(soldierInfo[4]);
                    var corps = soldierInfo[5];
                    Commando commando = new Commando(id, firstName, lastName, salary, corps);
                    var codeName = "";
                    var state = "";
                    for (int index = 6; index < soldierInfo.Length; index++)
                    {
                        if (index % 2 == 0)
                        {
                            codeName = soldierInfo[index];
                        }
                        else
                        {
                            state = soldierInfo[index];
                            Mission mission = new Mission(codeName, state);
                            commando.AddMission(mission);
                        }
                    }
                    Console.WriteLine(commando.ToString());
                }
                else if (input.StartsWith("Spy"))
                {
                    var codeNumber = int.Parse(soldierInfo[4]);
                    var spy = new Spy(id, firstName, lastName, codeNumber);
                    Console.WriteLine(spy.ToString());
                }
            }
        }
    }
}
