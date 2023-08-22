using RulesWorkerPoc.Enums;

namespace RulesWorkerPoc.Models.Dms.v1.Global
{
    [ManagementOrder(GroupEnum.Global, Identity = 2)]
    public sealed class FreightProgramInterchangeProgram : GlobalInterchangeProgram
    {
        public override string[] InterchangeRateDesignator => new[] { "FF" };

        public override string InterchangeProgramName => "Freight Program";

        public override string InterchangeRate => "00001,800000";

        public override string UnitFee => "000000,00000";
    }
}
