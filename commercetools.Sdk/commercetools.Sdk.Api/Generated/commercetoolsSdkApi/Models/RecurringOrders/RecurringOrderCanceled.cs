

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderCanceled : IRecurringOrderCanceled
    {
        public string Type { get; set; }

        public string Reason { get; set; }
        public RecurringOrderCanceled()
        {
            this.Type = "canceled";
        }
    }
}
