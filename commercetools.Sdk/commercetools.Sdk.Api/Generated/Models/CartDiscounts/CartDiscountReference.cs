using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountReference : ICartDiscountReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public ICartDiscount Obj { get; set; }
        public CartDiscountReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("cart-discount");
        }
    }
}
