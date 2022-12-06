using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ShippingDraft))]
    public partial interface IShippingDraft
    {
        string Key { get; set; }

        IShippingMethodReference ShippingMethod { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IShippingRateInputDraft ShippingRateInput { get; set; }

        string ExternalTaxRate { get; set; }

        IList<IDelivery> Deliveries { get; set; }
        IEnumerable<IDelivery> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        string Custom { get; set; }

    }
}
