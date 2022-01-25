using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductSelections
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
