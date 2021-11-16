using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditResourceIdentifier : IOrderEditResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public OrderEditResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("order-edit");
        }
    }
}
