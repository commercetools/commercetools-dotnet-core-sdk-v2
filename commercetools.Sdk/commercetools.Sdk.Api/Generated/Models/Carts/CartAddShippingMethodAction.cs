using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddShippingMethodAction : ICartAddShippingMethodAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public IShippingMethodReference ShippingMethod { get; set; }

        public IBaseAddress ShippingAddress { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }

        public string ExternalTaxRate { get; set; }

        public IList<IDelivery> Deliveries { get; set; }
        public IEnumerable<IDelivery> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        public string Custom { get; set; }
        public CartAddShippingMethodAction()
        {
            this.Action = "addShippingMethod";
        }
    }
}
