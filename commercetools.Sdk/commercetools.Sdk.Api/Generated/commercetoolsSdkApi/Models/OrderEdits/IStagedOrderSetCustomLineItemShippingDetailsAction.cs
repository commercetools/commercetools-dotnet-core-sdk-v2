using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsAction))]
    public partial interface IStagedOrderSetCustomLineItemShippingDetailsAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
