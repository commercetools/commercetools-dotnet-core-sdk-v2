using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderExpiresAtSetMessagePayload))]
    public partial interface IRecurringOrderExpiresAtSetMessagePayload : IMessagePayload
    {
        DateTime NewExpiresAt { get; set; }

        DateTime OldExpiresAt { get; set; }

    }
}
