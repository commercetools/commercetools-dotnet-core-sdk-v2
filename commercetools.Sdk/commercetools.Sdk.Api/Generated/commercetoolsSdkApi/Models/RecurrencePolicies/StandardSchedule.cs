

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class StandardSchedule : IStandardSchedule
    {
        public string Type { get; set; }

        public long Value { get; set; }

        public IIntervalUnit IntervalUnit { get; set; }
        public StandardSchedule()
        {
            this.Type = "standard";
        }
    }
}
