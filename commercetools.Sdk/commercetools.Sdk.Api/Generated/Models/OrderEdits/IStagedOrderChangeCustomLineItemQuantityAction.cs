using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemQuantityAction))]
    public partial interface IStagedOrderChangeCustomLineItemQuantityAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        long Quantity { get; set; }

    }
}
