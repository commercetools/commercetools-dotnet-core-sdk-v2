using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestUpdate : IQuoteRequestUpdate
    {
        public long Version { get; set; }

        public List<IQuoteRequestUpdateAction> Actions { get; set; }
    }
}
