
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : Private, ISpecialisedSoldier, IEngineer
    {
        private string corps;
        private List<Repair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
            repairs = new List<Repair>();
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

        public IReadOnlyCollection<IRepair> Repairs
            => repairs;

        public void AddRepair(Repair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");
            foreach (Repair repair in repairs)
            {
                sb.AppendLine(repair.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
