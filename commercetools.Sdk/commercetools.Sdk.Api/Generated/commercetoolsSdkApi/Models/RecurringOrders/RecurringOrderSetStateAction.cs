

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderSetStateAction : IRecurringOrderSetStateAction
    {
        public string Action { get; set; }

        public IRecurringOrderStateDraft RecurringOrderState { get; set; }
        public RecurringOrderSetStateAction()
        {
            this.Action = "setRecurringOrderState";
        }
    }
}
