using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemQuantityAction))]
    public partial interface IStagedOrderChangeCustomLineItemQuantityAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        double Quantity { get; set; }
    }
}
