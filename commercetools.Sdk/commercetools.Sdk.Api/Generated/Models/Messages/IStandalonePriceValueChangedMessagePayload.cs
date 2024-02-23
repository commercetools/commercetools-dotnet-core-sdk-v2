using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessagePayload))]
    public partial interface IStandalonePriceValueChangedMessagePayload : IMessagePayload
    {
        IMoney Value { get; set; }

        bool Staged { get; set; }

        IMoney OldValue { get; set; }

    }
}
