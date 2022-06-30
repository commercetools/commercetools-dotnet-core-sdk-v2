using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    public partial class StagedQuoteResourceIdentifier : IStagedQuoteResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public StagedQuoteResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("staged-quote");
        }
    }
}
