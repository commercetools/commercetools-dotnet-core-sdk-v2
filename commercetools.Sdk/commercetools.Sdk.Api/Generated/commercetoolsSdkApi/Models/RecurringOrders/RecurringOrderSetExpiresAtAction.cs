using System;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderSetExpiresAtAction : IRecurringOrderSetExpiresAtAction
    {
        public string Action { get; set; }

        public DateTime? ExpiresAt { get; set; }
        public RecurringOrderSetExpiresAtAction()
        {
            this.Action = "setExpiresAt";
        }
    }
}
