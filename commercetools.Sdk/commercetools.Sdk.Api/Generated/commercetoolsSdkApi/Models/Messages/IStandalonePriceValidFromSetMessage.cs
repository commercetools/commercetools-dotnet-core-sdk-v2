using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValidFromSetMessage))]
    public partial interface IStandalonePriceValidFromSetMessage : IMessage
    {
        DateTime? ValidFrom { get; set; }

        DateTime? PreviousValidFrom { get; set; }

    }
}
