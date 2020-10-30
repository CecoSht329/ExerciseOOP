
using System;

namespace MilitaryElite
{
    public class Mission : IMission
    {
        private string state;
        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; private set; }

        public string State
        {
            get
            {
                return state;
            }
            private set
            {
                if (value != MissionState.InProgress && value != MissionState.Finished)
                {
                    throw new ArgumentException();
                }
                state = value;
            }
        }


        public bool CompleteMission()
        {
            if (State != MissionState.Finished)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {State}";
        }
    }
}
