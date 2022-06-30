using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Quotes
{
    public partial class QuoteResourceIdentifier : IQuoteResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public QuoteResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("quote");
        }
    }
}
