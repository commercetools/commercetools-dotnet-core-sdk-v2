using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class ProductSelectionResourceIdentifier : IProductSelectionResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ProductSelectionResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-selection");
        }
    }
}
