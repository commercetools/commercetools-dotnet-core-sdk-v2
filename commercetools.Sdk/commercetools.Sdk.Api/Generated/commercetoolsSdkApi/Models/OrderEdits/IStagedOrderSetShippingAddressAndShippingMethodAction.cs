using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodAction))]
    public partial interface IStagedOrderSetShippingAddressAndShippingMethodAction : IStagedOrderUpdateAction
    {
        IBaseAddress Address { get; set; }

        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
