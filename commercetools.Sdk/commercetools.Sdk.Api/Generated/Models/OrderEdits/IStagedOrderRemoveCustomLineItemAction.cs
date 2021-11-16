using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveCustomLineItemAction))]
    public partial interface IStagedOrderRemoveCustomLineItemAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }
    }
}
