

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderRequestOrderNowAction : IRecurringOrderRequestOrderNowAction
    {
        public string Action { get; set; }

        public string Reason { get; set; }
        public RecurringOrderRequestOrderNowAction()
        {
            this.Action = "requestOrderNow";
        }
    }
}
