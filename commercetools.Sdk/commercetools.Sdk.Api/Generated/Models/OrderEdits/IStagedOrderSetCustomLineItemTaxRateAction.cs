using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxRateAction))]
    public partial interface IStagedOrderSetCustomLineItemTaxRateAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }
    }
}
