using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessage))]
    public partial interface IQuoteCreatedMessage : IMessage
    {
        IQuote Quote { get; set; }

    }
}
