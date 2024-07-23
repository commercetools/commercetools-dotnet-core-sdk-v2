using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessagePayload))]
    public partial interface IQuoteStateChangedMessagePayload : IMessagePayload
    {
        IQuoteState QuoteState { get; set; }

        IQuoteState OldQuoteState { get; set; }

    }
}
