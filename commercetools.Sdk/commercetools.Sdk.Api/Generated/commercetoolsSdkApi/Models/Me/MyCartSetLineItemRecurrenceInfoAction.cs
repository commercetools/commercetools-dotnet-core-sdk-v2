using commercetools.Sdk.Api.Models.RecurringOrders;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetLineItemRecurrenceInfoAction : IMyCartSetLineItemRecurrenceInfoAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public ILineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }
        public MyCartSetLineItemRecurrenceInfoAction()
        {
            this.Action = "setLineItemRecurrenceInfo";
        }
    }
}
