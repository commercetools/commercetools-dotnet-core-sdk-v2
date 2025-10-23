

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class LineItemRecurrenceInfo : ILineItemRecurrenceInfo
    {
        public IRecurrencePolicyReference RecurrencePolicy { get; set; }

        public IPriceSelectionMode PriceSelectionMode { get; set; }
    }
}
