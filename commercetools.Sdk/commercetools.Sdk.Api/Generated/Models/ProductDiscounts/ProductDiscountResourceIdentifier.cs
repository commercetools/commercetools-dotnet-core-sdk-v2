using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountResourceIdentifier : IProductDiscountResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ProductDiscountResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-discount");
        }
    }
}
