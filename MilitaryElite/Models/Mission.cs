
namespace MilitaryElite
{
    public enum State
    {
        inProgress,
        Finished
    }
    public class Mission
    {
        public Mission(string name, State state)
        {
            Name = name;
            State = state;
        }

        public string Name { get; private set; }

        public State State { get; private set; }

        public void CompeteMission()
        {
            this.State = State.Finished;
        }
        public override string ToString()
        {
            return $"Code Name: {this.Name} State: {this.State}";
        }
    }
}
