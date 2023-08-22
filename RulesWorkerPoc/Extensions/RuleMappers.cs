using RulesWorkerPoc.Enums;
using RulesWorkerPoc.Interfaces;
using RulesWorkerPoc.Models.Dms;
using RulesWorkerPoc.Models.Dms.v1.Global;

namespace RulesWorkerPoc.Extensions
{
    public static class RuleMappers
    {
        public static void MapGlobal(this IEnumerable<IManager> managers)
        {
            var numberOfAttributesToProgram = 2;
            var globalPrograms = DynamicallyCreateDictionary();

            Dictionary<long, GlobalInterchangeProgram> DynamicallyCreateDictionary()
            {
                var dictionary = new Dictionary<long, GlobalInterchangeProgram>();
                for (long i = 1; i <= numberOfAttributesToProgram; i++)
                {
                    dictionary[i] = default!;
                }

                return dictionary!;
            }

            Parallel.ForEach(managers.Where(r => r.GroupEnum.Equals(GroupEnum.Global)),
                new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount },
                manager =>
                {
                    Parallel.ForEach(manager.Namespace!.GetModelsFromNamespace(), type =>
                    {
                        var identity = type.GetIdentityFromRule();

                        if (globalPrograms.TryGetValue(identity, out var program))
                        {
                            program = Activator.CreateInstance(type) as GlobalInterchangeProgram;
                            globalPrograms[identity] = program!;
                        }
                    });
                });

            InterchangeDmsProgramsDictionary.GlobalPrograms = new Dictionary<string, GlobalInterchangeProgram>
            {
                { "BB", globalPrograms[1]! },
                { "FF", globalPrograms[2]! }
            };
        }
    }
}
