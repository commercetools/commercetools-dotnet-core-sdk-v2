

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrdersOnlyDraft : IRecurringOrdersOnlyDraft
    {
        public string Type { get; set; }
        public RecurringOrdersOnlyDraft()
        {
            this.Type = "RecurringOrdersOnly";
        }
    }
}
