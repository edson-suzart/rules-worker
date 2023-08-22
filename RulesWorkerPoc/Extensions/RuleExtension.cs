using System.Reflection;

namespace RulesWorkerPoc.Extensions
{
    public static class RuleExtension
    {
        public static long GetIdentityFromRule(this Type? obj)
        {
            object[] dbFieldAtts = obj!.GetCustomAttributes(typeof(ManagementOrderAttribute), false);

            if (dbFieldAtts != null && dbFieldAtts.Length > 0)
            {
                var order = ((ManagementOrderAttribute)dbFieldAtts[0]).Identity;

                return order;
            }

            throw new Exception("Atributo não contém identificador!");
        }

        public static IEnumerable<Type> GetModelsFromNamespace(this string ruleNamespace) =>
            Assembly
                  .GetExecutingAssembly()
                  .GetTypes()
                  .Where(type =>
                      type.Namespace != null &&
                      !type.IsNested &&
                      type.Namespace.Contains(ruleNamespace, StringComparison.InvariantCultureIgnoreCase)
                  )
                  .ToList();
    }
}
