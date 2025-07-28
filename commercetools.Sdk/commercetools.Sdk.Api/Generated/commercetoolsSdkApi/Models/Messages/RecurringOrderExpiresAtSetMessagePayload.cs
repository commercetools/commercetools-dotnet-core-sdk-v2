using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderExpiresAtSetMessagePayload : IRecurringOrderExpiresAtSetMessagePayload
    {
        public string Type { get; set; }

        public DateTime NewExpiresAt { get; set; }

        public DateTime OldExpiresAt { get; set; }
        public RecurringOrderExpiresAtSetMessagePayload()
        {
            this.Type = "RecurringOrderExpiresAtSet";
        }
    }
}
