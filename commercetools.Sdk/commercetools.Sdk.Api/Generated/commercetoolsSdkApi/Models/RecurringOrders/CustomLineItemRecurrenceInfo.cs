using commercetools.Sdk.Api.Models.RecurrencePolicies;


namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class CustomLineItemRecurrenceInfo : ICustomLineItemRecurrenceInfo
    {
        public IRecurrencePolicyReference RecurrencePolicy { get; set; }
    }
}
