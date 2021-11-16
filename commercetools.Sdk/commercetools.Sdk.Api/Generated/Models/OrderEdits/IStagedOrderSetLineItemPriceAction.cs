using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemPriceAction))]
    public partial interface IStagedOrderSetLineItemPriceAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set;}
        
        IMoney ExternalPrice { get; set;}
    }
}
