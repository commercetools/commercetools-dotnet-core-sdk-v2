using commercetools.Sdk.Api.Models.RecurrencePolicies;


namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class CustomLineItemRecurrenceInfoDraft : ICustomLineItemRecurrenceInfoDraft
    {
        public IRecurrencePolicyResourceIdentifier RecurrencePolicy { get; set; }
    }
}
