using commercetools.Sdk.Api.Models.RecurrencePolicies;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderScheduleSetMessagePayload : IRecurringOrderScheduleSetMessagePayload
    {
        public string Type { get; set; }

        public IRecurrencePolicySchedule RecurrencePolicySchedule { get; set; }

        public IRecurrencePolicySchedule OldRecurrencePolicySchedule { get; set; }
        public RecurringOrderScheduleSetMessagePayload()
        {
            this.Type = "RecurringOrderScheduleSet";
        }
    }
}
