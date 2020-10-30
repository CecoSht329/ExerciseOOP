
namespace MilitaryElite
{
    public interface IMission
    {
        //A mission holds code name and a state(inProgress or Finished).
        //    A Mission can be finished through the method CompleteMission().
        public string CodeName { get; }
        public string State { get; }
        public bool CompleteMission();
    }
}
