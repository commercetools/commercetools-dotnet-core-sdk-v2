using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromAndUntilSetMessage))]
    public partial interface IStandalonePriceValidFromAndUntilSetMessage : IMessage
    {
        DateTime? ValidFrom { get; set; }

        DateTime? PreviousValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        DateTime? PreviousValidUntil { get; set; }

    }
}
