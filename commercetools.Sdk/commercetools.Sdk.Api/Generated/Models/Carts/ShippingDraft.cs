using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ShippingDraft : IShippingDraft
    {
        public string Key { get; set; }

        public IShippingMethodReference ShippingMethod { get; set; }

        public IBaseAddress ShippingAddress { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }

        public string ExternalTaxRate { get; set; }

        public List<IDelivery> Deliveries { get; set; }

        public string Custom { get; set; }
    }
}
