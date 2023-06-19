using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteCreatedMessagePayload))]
    public partial interface IQuoteCreatedMessagePayload : IMessagePayload
    {
        IQuote Quote { get; set; }

    }
}
