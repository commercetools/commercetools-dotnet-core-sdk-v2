using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessagePayload))]
    public partial interface IStagedQuoteCreatedMessagePayload : IMessagePayload
    {
        IStagedQuote StagedQuote { get; set; }

    }
}
