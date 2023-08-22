using RulesWorkerPoc.Models.Dms;
using RulesWorkerPoc.Models.Dms.v1.Global;
using RulesWorkerPoc.Models.Managers;

namespace RulesWorkerPoc
{
    public static class Program
    {
        public static async Task Main()
        {
            var rule = RuleManager.ChooseRuleFromPeriod(new DateTime(2023, 01, 01));
            await InterchangeDmsProgramsDictionary.CreateInstanceToAllRules(rule);

            var result = GetGlobalProgram("BB");
            Console.WriteLine(result);
        }

        private static GlobalInterchangeProgram GetGlobalProgram(string selectedIrd)
        {
            if (InterchangeDmsProgramsDictionary.GlobalPrograms.TryGetValue(selectedIrd, out var program))
                return program;

            throw new Exception($"Not found program in {nameof(GlobalInterchangeProgram)} with IRD {selectedIrd}");
        }
    }
}