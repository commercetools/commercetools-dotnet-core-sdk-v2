using System;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderSetCustomFieldAction : IRecurringOrderSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public RecurringOrderSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
