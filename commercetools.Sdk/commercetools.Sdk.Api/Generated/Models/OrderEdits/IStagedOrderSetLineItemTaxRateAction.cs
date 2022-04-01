using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxRateAction))]
    public partial interface IStagedOrderSetLineItemTaxRateAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }
    }
}
