using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteDraft : IQuoteDraft
    {
        public IStagedQuoteResourceIdentifier StagedQuote { get; set; }

        public long StagedQuoteVersion { get; set; }

        public string Key { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
