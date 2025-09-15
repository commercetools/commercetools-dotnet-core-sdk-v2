using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.Carts
{

    public partial class CartReference : ICartReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public CartReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("cart");
        }
    }
}
