using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetLineItemShippingDetailsAction))]
    public partial interface IOrderSetLineItemShippingDetailsAction : IOrderUpdateAction
    {
        string LineItemId { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
