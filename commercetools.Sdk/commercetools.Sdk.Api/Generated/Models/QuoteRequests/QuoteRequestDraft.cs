using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestDraft : IQuoteRequestDraft
    {
        public ICartResourceIdentifier Cart { get; set; }

        public long CartVersion { get; set; }

        public string Key { get; set; }

        public string Comment { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
