using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderReference : IOrderReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public IOrder Obj { get; set;}
        public OrderReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("order");
        }
    }
}
