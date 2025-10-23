

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ShippingMethodReference : IShippingMethodReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public ShippingMethodReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("shipping-method");
        }
    }
}
