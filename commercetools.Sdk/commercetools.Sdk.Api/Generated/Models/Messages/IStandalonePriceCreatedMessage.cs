using commercetools.Sdk.Api.Models.StandalonePrices;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceCreatedMessage))]
    public partial interface IStandalonePriceCreatedMessage : IMessage
    {
        IStandalonePrice StandalonePrice { get; set; }
    }
}
