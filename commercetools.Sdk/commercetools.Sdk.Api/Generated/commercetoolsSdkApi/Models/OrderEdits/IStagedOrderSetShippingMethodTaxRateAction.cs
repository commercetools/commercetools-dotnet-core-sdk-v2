using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxRateAction))]
    public partial interface IStagedOrderSetShippingMethodTaxRateAction : IStagedOrderUpdateAction
    {
        string ShippingKey { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
