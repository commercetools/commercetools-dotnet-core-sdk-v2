using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductSelections
{
    public partial class ProductSelectionReference : IProductSelectionReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IProductSelection Obj { get; set; }
        public ProductSelectionReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-selection");
        }
    }
}
