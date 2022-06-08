using commercetools.Sdk.Api.Models.StandalonePrices;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessagePayload))]
    public partial interface IStandalonePriceCreatedMessagePayload : IMessagePayload
    {
        IStandalonePrice StandalonePrice { get; set; }
    }
}
