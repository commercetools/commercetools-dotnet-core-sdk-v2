using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    public partial class TaxCategoryResourceIdentifier : ITaxCategoryResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public TaxCategoryResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("tax-category");
        }
    }
}
