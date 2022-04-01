using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderReference : IOrderReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IOrder Obj { get; set; }
        public OrderReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("order");
        }
    }
}
