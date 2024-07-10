using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodAction))]
    public partial interface IStagedOrderSetShippingMethodAction : IStagedOrderUpdateAction
    {
        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
