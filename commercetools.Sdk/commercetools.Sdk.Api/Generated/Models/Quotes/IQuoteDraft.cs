using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteDraft))]
    public partial interface IQuoteDraft
    {
        IStagedQuoteResourceIdentifier StagedQuote { get; set; }

        long StagedQuoteVersion { get; set; }

        bool? StagedQuoteStateToSent { get; set; }

        string Key { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IStateReference State { get; set; }

    }
}
