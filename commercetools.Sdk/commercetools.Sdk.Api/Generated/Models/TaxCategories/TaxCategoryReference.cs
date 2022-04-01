using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    public partial class TaxCategoryReference : ITaxCategoryReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public ITaxCategory Obj { get; set; }
        public TaxCategoryReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("tax-category");
        }
    }
}
