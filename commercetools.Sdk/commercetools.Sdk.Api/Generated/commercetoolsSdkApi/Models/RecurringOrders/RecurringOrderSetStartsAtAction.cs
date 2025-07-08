using System;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderSetStartsAtAction : IRecurringOrderSetStartsAtAction
    {
        public string Action { get; set; }

        public DateTime StartsAt { get; set; }
        public RecurringOrderSetStartsAtAction()
        {
            this.Action = "setStartsAt";
        }
    }
}
