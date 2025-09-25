using System;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderSetOrderSkipConfigurationAction : IRecurringOrderSetOrderSkipConfigurationAction
    {
        public string Action { get; set; }

        public ISkipConfigurationDraft SkipConfigurationInputDraft { get; set; }

        public DateTime? UpdatedExpiresAt { get; set; }
        public RecurringOrderSetOrderSkipConfigurationAction()
        {
            this.Action = "setOrderSkipConfiguration";
        }
    }
}
