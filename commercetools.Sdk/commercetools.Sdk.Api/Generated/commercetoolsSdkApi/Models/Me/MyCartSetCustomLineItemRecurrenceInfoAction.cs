using commercetools.Sdk.Api.Models.RecurringOrders;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetCustomLineItemRecurrenceInfoAction : IMyCartSetCustomLineItemRecurrenceInfoAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public ICustomLineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }
        public MyCartSetCustomLineItemRecurrenceInfoAction()
        {
            this.Action = "setCustomLineItemRecurrenceInfo";
        }
    }
}
