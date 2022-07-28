using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveCustomLineItemAction))]
    public partial interface IStagedOrderRemoveCustomLineItemAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

    }
}
