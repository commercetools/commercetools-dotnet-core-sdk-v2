using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromAndUntilSetMessagePayload))]
    public partial interface IStandalonePriceValidFromAndUntilSetMessagePayload : IMessagePayload
    {
        DateTime? ValidFrom { get; set; }

        DateTime? PreviousValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        DateTime? PreviousValidUntil { get; set; }

    }
}
