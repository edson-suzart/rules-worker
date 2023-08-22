using RulesWorkerPoc.Enums;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class ManagementOrderAttribute : Attribute
{
    public readonly GroupEnum Group;
    public long Identity;

    public ManagementOrderAttribute(GroupEnum group)
    {
        Group = group;
        Identity = default;
    }
}