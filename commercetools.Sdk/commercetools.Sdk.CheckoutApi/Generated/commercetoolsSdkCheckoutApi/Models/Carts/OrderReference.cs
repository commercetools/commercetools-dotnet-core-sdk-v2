using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.Carts
{

    public partial class OrderReference : IOrderReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public OrderReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("order");
        }
    }
}
