

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class DayOfMonthSchedule : IDayOfMonthSchedule
    {
        public string Type { get; set; }

        public int Day { get; set; }
        public DayOfMonthSchedule()
        {
            this.Type = "dayOfMonth";
        }
    }
}
