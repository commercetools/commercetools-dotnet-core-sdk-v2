using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteUpdate : IQuoteUpdate
    {
        public long Version { get; set; }

        public List<IQuoteUpdateAction> Actions { get; set; }
    }
}
