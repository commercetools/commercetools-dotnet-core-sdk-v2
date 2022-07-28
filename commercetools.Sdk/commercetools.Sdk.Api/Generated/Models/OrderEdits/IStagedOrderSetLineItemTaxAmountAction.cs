using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTaxAmountAction))]
    public partial interface IStagedOrderSetLineItemTaxAmountAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }

    }
}
