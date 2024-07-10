using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringReference : IProductTailoringReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IProductTailoring Obj { get; set; }
        public ProductTailoringReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-tailoring");
        }
    }
}
