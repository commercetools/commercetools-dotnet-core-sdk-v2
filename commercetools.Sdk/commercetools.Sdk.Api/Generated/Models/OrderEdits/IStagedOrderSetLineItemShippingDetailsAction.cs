using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemShippingDetailsAction))]
    public partial interface IStagedOrderSetLineItemShippingDetailsAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
