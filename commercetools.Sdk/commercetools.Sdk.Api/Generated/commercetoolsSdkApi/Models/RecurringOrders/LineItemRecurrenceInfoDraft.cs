using commercetools.Sdk.Api.Models.RecurrencePolicies;


namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class LineItemRecurrenceInfoDraft : ILineItemRecurrenceInfoDraft
    {
        public IRecurrencePolicyResourceIdentifier RecurrencePolicy { get; set; }

        public IPriceSelectionMode PriceSelectionMode { get; set; }
    }
}
