using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessage))]
    public partial interface IQuoteRequestStateChangedMessage : IMessage
    {
        IQuoteRequestState QuoteRequestState { get; set; }

        IQuoteRequestState OldQuoteRequestState { get; set; }

    }
}
