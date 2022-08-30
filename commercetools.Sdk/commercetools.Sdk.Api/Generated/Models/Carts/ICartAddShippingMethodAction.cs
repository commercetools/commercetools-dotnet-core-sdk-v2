using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddShippingMethodAction))]
    public partial interface ICartAddShippingMethodAction : ICartUpdateAction
    {
        string ShippingKey { get; set; }

        IShippingMethodReference ShippingMethod { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IShippingRateInputDraft ShippingRateInput { get; set; }

        string ExternalTaxRate { get; set; }

        List<IDelivery> Deliveries { get; set; }

        string Custom { get; set; }

    }
}
