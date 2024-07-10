using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestResourceIdentifier : IQuoteRequestResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public QuoteRequestResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("quote-request");
        }
    }
}
