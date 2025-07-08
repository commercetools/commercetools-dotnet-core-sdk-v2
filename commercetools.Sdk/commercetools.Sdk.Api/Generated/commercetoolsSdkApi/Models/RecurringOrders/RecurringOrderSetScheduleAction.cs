using commercetools.Sdk.Api.Models.RecurrencePolicies;


namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderSetScheduleAction : IRecurringOrderSetScheduleAction
    {
        public string Action { get; set; }

        public IRecurrencePolicyResourceIdentifier RecurrencePolicy { get; set; }
        public RecurringOrderSetScheduleAction()
        {
            this.Action = "setSchedule";
        }
    }
}
