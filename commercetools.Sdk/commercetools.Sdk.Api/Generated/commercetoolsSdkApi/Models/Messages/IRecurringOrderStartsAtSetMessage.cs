using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderStartsAtSetMessage))]
    public partial interface IRecurringOrderStartsAtSetMessage : IMessage
    {
        DateTime StartsAt { get; set; }

        DateTime OldStartsAt { get; set; }

    }
}
