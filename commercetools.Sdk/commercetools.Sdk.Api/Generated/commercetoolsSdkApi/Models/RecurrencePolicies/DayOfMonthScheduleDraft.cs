

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class DayOfMonthScheduleDraft : IDayOfMonthScheduleDraft
    {
        public string Type { get; set; }

        public int Day { get; set; }
        public DayOfMonthScheduleDraft()
        {
            this.Type = "dayOfMonth";
        }
    }
}
