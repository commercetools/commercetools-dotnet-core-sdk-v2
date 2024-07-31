using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteRenegotiationRequestedMessagePayload))]
    public partial interface IQuoteRenegotiationRequestedMessagePayload : IMessagePayload
    {
        string BuyerComment { get; set; }

    }
}
