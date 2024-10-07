using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValidUntilSetMessage))]
    public partial interface IStandalonePriceValidUntilSetMessage : IMessage
    {
        DateTime? ValidUntil { get; set; }

        DateTime? PreviousValidUntil { get; set; }

    }
}
