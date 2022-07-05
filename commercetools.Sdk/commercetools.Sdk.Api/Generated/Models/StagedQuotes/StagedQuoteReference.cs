using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteReference : IStagedQuoteReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IStagedQuote Obj { get; set; }
        public StagedQuoteReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("staged-quote");
        }
    }
}
