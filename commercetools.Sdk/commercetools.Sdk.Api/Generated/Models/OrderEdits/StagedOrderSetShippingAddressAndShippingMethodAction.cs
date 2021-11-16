using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetShippingAddressAndShippingMethodAction : IStagedOrderSetShippingAddressAndShippingMethodAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public StagedOrderSetShippingAddressAndShippingMethodAction()
        {
            this.Action = "setShippingAddressAndShippingMethod";
        }
    }
}
