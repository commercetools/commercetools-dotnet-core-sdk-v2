using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteRenegotiationRequestedMessage))]
    public partial interface IQuoteRenegotiationRequestedMessage : IMessage
    {
        string BuyerComment { get; set; }

    }
}
