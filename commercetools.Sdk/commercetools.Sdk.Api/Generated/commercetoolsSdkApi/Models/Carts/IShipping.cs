using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.Shipping))]
    public partial interface IShipping
    {
        string ShippingKey { get; set; }

        IShippingInfo ShippingInfo { get; set; }

        IAddress ShippingAddress { get; set; }

        IShippingRateInput ShippingRateInput { get; set; }

        ICustomFields ShippingCustomFields { get; set; }

    }
}
