using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderNowRequestedMessagePayload))]
    public partial interface IRecurringOrderNowRequestedMessagePayload : IMessagePayload
    {
        DateTime RequestedAt { get; set; }

        string Reason { get; set; }

    }
}
