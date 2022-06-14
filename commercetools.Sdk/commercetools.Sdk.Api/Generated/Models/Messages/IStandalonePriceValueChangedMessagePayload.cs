using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessagePayload))]
    public partial interface IStandalonePriceValueChangedMessagePayload : IMessagePayload
    {
        IMoney Value { get; set; }
    }
}
