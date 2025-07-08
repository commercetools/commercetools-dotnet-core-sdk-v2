using commercetools.Sdk.Api.Models.RecurrencePolicies;


namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class LineItemRecurrenceInfo : ILineItemRecurrenceInfo
    {
        public IRecurrencePolicyReference RecurrencePolicy { get; set; }

        public IPriceSelectionMode PriceSelectionMode { get; set; }
    }
}
