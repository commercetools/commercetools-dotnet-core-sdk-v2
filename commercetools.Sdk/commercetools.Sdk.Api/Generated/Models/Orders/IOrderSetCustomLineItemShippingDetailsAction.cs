using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemShippingDetailsAction))]
    public partial interface IOrderSetCustomLineItemShippingDetailsAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
