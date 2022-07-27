using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Orders
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
