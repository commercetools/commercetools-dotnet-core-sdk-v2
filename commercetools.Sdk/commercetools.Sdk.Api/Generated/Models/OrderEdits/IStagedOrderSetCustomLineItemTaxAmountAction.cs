using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxAmountAction))]
    public partial interface IStagedOrderSetCustomLineItemTaxAmountAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }

    }
}
