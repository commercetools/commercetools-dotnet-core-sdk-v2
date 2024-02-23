using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestReference : IQuoteRequestReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IQuoteRequest Obj { get; set; }
        public QuoteRequestReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("quote-request");
        }
    }
}
