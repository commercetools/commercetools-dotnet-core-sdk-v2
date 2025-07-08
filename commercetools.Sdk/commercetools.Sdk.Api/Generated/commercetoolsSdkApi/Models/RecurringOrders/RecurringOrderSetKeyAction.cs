

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderSetKeyAction : IRecurringOrderSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public RecurringOrderSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
