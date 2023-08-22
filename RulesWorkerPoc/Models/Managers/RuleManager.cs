using RulesWorkerPoc.Enums;
using RulesWorkerPoc.Interfaces;
using RulesWorkerPoc.Registration;

namespace RulesWorkerPoc.Models.Managers
{
    public static class RuleManager
    {
        public static IEnumerable<IManager> ChooseRuleFromPeriod(DateTime ruleDate)
        {
            var rules = RegisteredRules.GetRules();

            if (rules.Any())
                return rules.Where(r => r.Enabled && r.StartDate <= ruleDate);

            throw new Exception("Regra nao encontrada no periodo requerido!");
        }
    }
}
