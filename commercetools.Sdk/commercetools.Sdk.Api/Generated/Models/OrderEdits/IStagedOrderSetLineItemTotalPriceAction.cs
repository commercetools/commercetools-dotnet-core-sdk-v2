using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemTotalPriceAction))]
    public partial interface IStagedOrderSetLineItemTotalPriceAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }
    }
}
