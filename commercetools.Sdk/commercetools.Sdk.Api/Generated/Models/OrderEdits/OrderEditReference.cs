using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.OrderEdits
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
