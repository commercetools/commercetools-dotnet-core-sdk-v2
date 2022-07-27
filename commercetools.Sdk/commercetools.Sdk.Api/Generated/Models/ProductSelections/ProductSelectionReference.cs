using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductSelections
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
