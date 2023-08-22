using RulesWorkerPoc.Enums;
using RulesWorkerPoc.Interfaces;

namespace RulesWorkerPoc.Rules.v1
{
    public class GlobalManagerv1 : IManager
    {
        public GlobalManagerv1(DateTime startDate, bool enabled)
        {
            StartDate = startDate;
            Enabled = enabled;
        }

        public bool Enabled { get; set; }
        public DateTime StartDate { get; set; }
        public GroupEnum GroupEnum { get; set; } = GroupEnum.Global;
        public string? Namespace { get; set; } = "RulesWorkerPoc.Models.Dms.v1.Global";
    }
}
