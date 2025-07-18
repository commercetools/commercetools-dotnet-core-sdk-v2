using commercetools.Sdk.Api.Models.RecurringOrders;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomLineItemRecurrenceInfoAction : ICartSetCustomLineItemRecurrenceInfoAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public ICustomLineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }
        public CartSetCustomLineItemRecurrenceInfoAction()
        {
            this.Action = "setCustomLineItemRecurrenceInfo";
        }
    }
}
