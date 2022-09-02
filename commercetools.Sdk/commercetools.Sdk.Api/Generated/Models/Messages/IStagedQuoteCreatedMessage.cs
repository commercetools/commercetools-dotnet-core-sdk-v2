using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteCreatedMessage))]
    public partial interface IStagedQuoteCreatedMessage : IMessage
    {
        IStagedQuote StagedQuote { get; set; }

    }
}
