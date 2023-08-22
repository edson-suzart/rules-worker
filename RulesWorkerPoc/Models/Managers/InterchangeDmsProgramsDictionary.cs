using RulesWorkerPoc.Extensions;
using RulesWorkerPoc.Interfaces;
using RulesWorkerPoc.Models.Dms.v1.Global;

namespace RulesWorkerPoc.Models.Dms
{
    public static class InterchangeDmsProgramsDictionary
    {
        public static async Task CreateInstanceToAllRules(IEnumerable<IManager> rules)
        {
            var tasks = new List<Task>
            {
                Task.Run(() => rules.MapGlobal())
            };

            await Task.WhenAll(tasks);
        }

        #region GlobalPrograms
        public static IDictionary<string, GlobalInterchangeProgram> GlobalPrograms = new Dictionary<string, GlobalInterchangeProgram>();
        #endregion
    }
}
