using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemTaxAmountAction))]
    public partial interface IStagedOrderSetLineItemTaxAmountAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set;}
        
        IExternalTaxAmountDraft ExternalTaxAmount { get; set;}
    }
}
