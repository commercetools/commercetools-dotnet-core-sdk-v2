using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessagePayload))]
    public partial interface IQuoteRequestStateChangedMessagePayload : IMessagePayload
    {
        IQuoteRequestState QuoteRequestState { get; set; }

        IQuoteRequestState OldQuoteRequestState { get; set; }
    }
}
