

namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodSetCarrierAction : IShippingMethodSetCarrierAction
    {
        public string Action { get; set; }

        public string Carrier { get; set; }
        public ShippingMethodSetCarrierAction()
        {
            this.Action = "setCarrier";
        }
    }
}
