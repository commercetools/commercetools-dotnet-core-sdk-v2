using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountReference : IProductDiscountReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IProductDiscount Obj { get; set; }
        public ProductDiscountReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-discount");
        }
    }
}
