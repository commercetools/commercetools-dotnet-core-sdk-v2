using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddShippingMethodAction : ICartAddShippingMethodAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public IBaseAddress ShippingAddress { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public IList<IDeliveryDraft> Deliveries { get; set; }
        public IEnumerable<IDeliveryDraft> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        public ICustomFieldsDraft Custom { get; set; }
        public CartAddShippingMethodAction()
        {
            this.Action = "addShippingMethod";
        }
    }
}
