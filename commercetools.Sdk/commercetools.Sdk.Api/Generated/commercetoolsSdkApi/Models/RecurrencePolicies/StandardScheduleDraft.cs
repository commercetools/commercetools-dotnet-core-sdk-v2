

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class StandardScheduleDraft : IStandardScheduleDraft
    {
        public string Type { get; set; }

        public long Value { get; set; }

        public IIntervalUnit IntervalUnit { get; set; }
        public StandardScheduleDraft()
        {
            this.Type = "standard";
        }
    }
}
