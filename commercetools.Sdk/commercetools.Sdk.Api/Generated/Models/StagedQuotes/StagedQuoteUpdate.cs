using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    public partial class StagedQuoteUpdate : IStagedQuoteUpdate
    {
        public long Version { get; set; }

        public List<IStagedQuoteUpdateAction> Actions { get; set; }
    }
}
