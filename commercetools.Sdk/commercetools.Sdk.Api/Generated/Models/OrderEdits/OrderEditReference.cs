using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditReference : IOrderEditReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IOrderEdit Obj { get; set; }
        public OrderEditReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("order-edit");
        }
    }
}
