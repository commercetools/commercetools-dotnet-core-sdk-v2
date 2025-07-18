using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderStartsAtSetMessagePayload))]
    public partial interface IRecurringOrderStartsAtSetMessagePayload : IMessagePayload
    {
        DateTime StartsAt { get; set; }

        DateTime OldStartsAt { get; set; }

    }
}
