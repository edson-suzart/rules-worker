using RulesWorkerPoc.Interfaces;
using RulesWorkerPoc.Rules.v1;

namespace RulesWorkerPoc.Registration
{
    public class RegisteredRules
    {
        public static IEnumerable<IManager> GetRules()
        {
            var rules = new List<IManager>();

            #region rules v1
            var globalv1 = new GlobalManagerv1(new DateTime(2023, 01, 01), true);
            #endregion

            rules.Add(globalv1);

            return rules;
        }
    }
}
