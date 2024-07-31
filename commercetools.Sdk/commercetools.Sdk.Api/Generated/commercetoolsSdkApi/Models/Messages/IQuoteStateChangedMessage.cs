using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessage))]
    public partial interface IQuoteStateChangedMessage : IMessage
    {
        IQuoteState QuoteState { get; set; }

        IQuoteState OldQuoteState { get; set; }

    }
}
