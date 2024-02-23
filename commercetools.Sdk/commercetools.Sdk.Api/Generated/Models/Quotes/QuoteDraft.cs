using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteDraft : IQuoteDraft
    {
        public string Key { get; set; }

        public IStagedQuoteResourceIdentifier StagedQuote { get; set; }

        public long StagedQuoteVersion { get; set; }

        public bool? StagedQuoteStateToSent { get; set; }

        public IStateReference State { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
