using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    public partial class ShippingMethodReference : IShippingMethodReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IShippingMethod Obj { get; set; }
        public ShippingMethodReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("shipping-method");
        }
    }
}
