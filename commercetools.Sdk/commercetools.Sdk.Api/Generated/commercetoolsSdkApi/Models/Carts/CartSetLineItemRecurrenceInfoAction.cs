using commercetools.Sdk.Api.Models.RecurringOrders;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetLineItemRecurrenceInfoAction : ICartSetLineItemRecurrenceInfoAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public ILineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }
        public CartSetLineItemRecurrenceInfoAction()
        {
            this.Action = "setLineItemRecurrenceInfo";
        }
    }
}
