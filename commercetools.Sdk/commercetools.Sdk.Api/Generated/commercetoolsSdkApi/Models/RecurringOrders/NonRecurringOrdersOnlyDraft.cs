

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class NonRecurringOrdersOnlyDraft : INonRecurringOrdersOnlyDraft
    {
        public string Type { get; set; }
        public NonRecurringOrdersOnlyDraft()
        {
            this.Type = "NonRecurringOrdersOnly";
        }
    }
}
