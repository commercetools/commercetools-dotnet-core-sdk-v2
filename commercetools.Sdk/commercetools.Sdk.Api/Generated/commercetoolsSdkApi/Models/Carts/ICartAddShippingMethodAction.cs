using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddShippingMethodAction))]
    public partial interface ICartAddShippingMethodAction : ICartUpdateAction
    {
        string ShippingKey { get; set; }

        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IShippingRateInputDraft ShippingRateInput { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        IList<IDeliveryDraft> Deliveries { get; set; }

        IEnumerable<IDeliveryDraft> DeliveriesEnumerable { set => Deliveries = value.ToList(); }

        ICustomFieldsDraft Custom { get; set; }

    }
}
