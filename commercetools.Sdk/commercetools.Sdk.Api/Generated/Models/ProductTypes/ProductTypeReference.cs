using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeReference : IProductTypeReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IProductType Obj { get; set; }
        public ProductTypeReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-type");
        }
    }
}
