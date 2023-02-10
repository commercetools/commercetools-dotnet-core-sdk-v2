using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessage))]
    public partial interface IStandalonePriceValueChangedMessage : IMessage
    {
        IMoney Value { get; set; }

        bool Staged { get; set; }

        IMoney OldValue { get; set; }

    }
}
