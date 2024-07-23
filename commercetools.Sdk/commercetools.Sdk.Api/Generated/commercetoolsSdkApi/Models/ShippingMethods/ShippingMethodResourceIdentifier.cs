using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodResourceIdentifier : IShippingMethodResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ShippingMethodResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("shipping-method");
        }
    }
}
