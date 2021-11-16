using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerReference : ICustomerReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public ICustomer Obj { get; set;}
        public CustomerReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("customer");
        }
    }
}
