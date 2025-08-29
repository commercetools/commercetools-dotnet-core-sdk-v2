using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.Orders
{

    public partial class OrderResourceIdentifier : IOrderResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public OrderResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("order");
        }
    }
}
