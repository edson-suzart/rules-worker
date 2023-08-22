namespace RulesWorkerPoc.Models.Dms
{
    public abstract class InterchangeDmsProgram
    {
        public abstract string[] InterchangeRateDesignator { get; }

        public abstract string InterchangeProgramName { get; }

        public virtual string? InterchangeRate { get; }

        public virtual string? UnitFee { get; }
    }
}
