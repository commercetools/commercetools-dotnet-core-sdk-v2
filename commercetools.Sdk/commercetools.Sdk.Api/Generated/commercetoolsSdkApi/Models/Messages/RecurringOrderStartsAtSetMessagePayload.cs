using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderStartsAtSetMessagePayload : IRecurringOrderStartsAtSetMessagePayload
    {
        public string Type { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime OldStartsAt { get; set; }
        public RecurringOrderStartsAtSetMessagePayload()
        {
            this.Type = "RecurringOrderStartsAtSet";
        }
    }
}
