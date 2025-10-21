using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderFailedMessagePayload))]
    public partial interface IRecurringOrderFailedMessagePayload : IMessagePayload
    {
        string CartId { get; set; }

        DateTime FailedAt { get; set; }

        string FailureReason { get; set; }

        DateTime OrderScheduledAt { get; set; }

        IList<IRecurringOrderFailureError> Errors { get; set; }

        IEnumerable<IRecurringOrderFailureError> ErrorsEnumerable { set => Errors = value.ToList(); }

    }
}
