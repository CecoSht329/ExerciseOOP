

using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace MilitaryElite
{
    public class Commando : Private, ISpecialisedSoldier, ICommando
    {
        private string corps;
        private List<Mission> missions;
        public Commando(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
            missions = new List<Mission>();
        }

        public string Corps
        {
            get
            {
                return corps;
            }
            private set
            {
                if (value != TypeSpecialSoldier.Airforces && value != TypeSpecialSoldier.Marines)
                {
                    throw new ArgumentException();
                }
                corps = value;
            }
        }

        public IReadOnlyCollection<IMission> Missions
            => missions;
        public void AddMission(Mission mission)
        {
            missions.Add(mission);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine($"Missions:");
            foreach (Mission mission in missions)
            {
                if (!mission.CompleteMission())
                {
                    sb.AppendLine("  " + mission.ToString());
                }
            }
            return sb.ToString().Trim();
        }
    }
}
