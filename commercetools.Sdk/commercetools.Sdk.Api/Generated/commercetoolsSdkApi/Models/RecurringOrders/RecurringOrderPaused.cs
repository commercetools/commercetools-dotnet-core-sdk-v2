

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderPaused : IRecurringOrderPaused
    {
        public string Type { get; set; }
        public RecurringOrderPaused()
        {
            this.Type = "paused";
        }
    }
}
