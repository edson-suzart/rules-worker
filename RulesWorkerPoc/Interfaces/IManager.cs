using RulesWorkerPoc.Enums;

namespace RulesWorkerPoc.Interfaces
{
    public interface IManager
    {
        public bool Enabled { get; set; }
        public DateTime StartDate { get; set; }
        public string? Namespace { get; set; }
        public GroupEnum GroupEnum { get; set; }
    }
}