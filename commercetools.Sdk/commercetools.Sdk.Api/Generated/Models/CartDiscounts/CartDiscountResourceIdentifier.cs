using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountResourceIdentifier : ICartDiscountResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public CartDiscountResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("cart-discount");
        }
    }
}
