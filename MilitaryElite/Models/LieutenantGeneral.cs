
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<Private> soldiers;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            soldiers = new List<Private>();
        }

        public IReadOnlyCollection<ISoldier> Soldiers
            => soldiers;

        public void AddSoldier(List<Private> privates, string id)
        {
            foreach (Private @private in privates)
            {
                if (@private.Id == id)
                {
                    soldiers.Add(@private);
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine("Privates:");
            foreach (var soldier in soldiers)
            {
                sb.AppendLine("  " + soldier.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
