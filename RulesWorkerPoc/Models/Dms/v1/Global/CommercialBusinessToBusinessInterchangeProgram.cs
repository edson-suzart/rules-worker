using RulesWorkerPoc.Enums;

namespace RulesWorkerPoc.Models.Dms.v1.Global
{
    [ManagementOrder(GroupEnum.Global, Identity = 1)]
    public sealed class CommercialBusinessToBusinessInterchangeProgram : GlobalInterchangeProgram
    {
        public override string[] InterchangeRateDesignator => new[] { "BB" };

        public override string InterchangeProgramName => "Commercial Business-to-Business";

        public override string InterchangeRate => "00002,000000";
        
        public override string UnitFee => "000000,00000";
    }
}
