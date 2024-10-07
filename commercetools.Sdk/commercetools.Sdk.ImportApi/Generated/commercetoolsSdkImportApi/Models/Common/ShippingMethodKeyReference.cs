

namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class ShippingMethodKeyReference : IShippingMethodKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public ShippingMethodKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("shipping-method");
        }
    }
}
