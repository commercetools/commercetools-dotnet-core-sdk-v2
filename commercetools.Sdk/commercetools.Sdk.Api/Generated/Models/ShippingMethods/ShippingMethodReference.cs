using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodReference : IShippingMethodReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public IShippingMethod Obj { get; set;}
        public ShippingMethodReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("shipping-method");
        }
    }
}
