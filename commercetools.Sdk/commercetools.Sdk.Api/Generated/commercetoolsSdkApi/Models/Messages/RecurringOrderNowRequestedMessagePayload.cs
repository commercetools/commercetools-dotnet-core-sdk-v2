using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderNowRequestedMessagePayload : IRecurringOrderNowRequestedMessagePayload
    {
        public string Type { get; set; }

        public DateTime RequestedAt { get; set; }

        public string Reason { get; set; }
        public RecurringOrderNowRequestedMessagePayload()
        {
            this.Type = "RecurringOrderNowRequested";
        }
    }
}
