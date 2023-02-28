using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Types;
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

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        IList<IDeliveryDraft> Deliveries { get; set; }
        IEnumerable<IDeliveryDraft> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
