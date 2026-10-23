using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderNowRequestedMessage))]
    public partial interface IRecurringOrderNowRequestedMessage : IMessage
    {
        DateTime RequestedAt { get; set; }

        string Reason { get; set; }

    }
}
