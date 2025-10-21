using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderFailedMessagePayload : IRecurringOrderFailedMessagePayload
    {
        public string Type { get; set; }

        public string CartId { get; set; }

        public DateTime FailedAt { get; set; }

        public string FailureReason { get; set; }

        public DateTime OrderScheduledAt { get; set; }

        public IList<IRecurringOrderFailureError> Errors { get; set; }

        public IEnumerable<IRecurringOrderFailureError> ErrorsEnumerable { set => Errors = value.ToList(); }
        public RecurringOrderFailedMessagePayload()
        {
            this.Type = "RecurringOrderFailed";
        }
    }
}
