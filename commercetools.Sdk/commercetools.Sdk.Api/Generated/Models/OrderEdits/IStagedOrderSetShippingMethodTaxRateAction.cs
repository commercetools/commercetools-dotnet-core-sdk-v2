using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxRateAction))]
    public partial interface IStagedOrderSetShippingMethodTaxRateAction : IStagedOrderUpdateAction
    {
        IExternalTaxRateDraft ExternalTaxRate { get; set; }
    }
}
