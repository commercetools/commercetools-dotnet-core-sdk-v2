using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteReference : IQuoteReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IQuote Obj { get; set; }
        public QuoteReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("quote");
        }
    }
}
