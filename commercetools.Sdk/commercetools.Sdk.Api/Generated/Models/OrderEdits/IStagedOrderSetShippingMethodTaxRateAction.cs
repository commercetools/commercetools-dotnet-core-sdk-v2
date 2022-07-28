using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxRateAction))]
    public partial interface IStagedOrderSetShippingMethodTaxRateAction : IStagedOrderUpdateAction
    {
        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
