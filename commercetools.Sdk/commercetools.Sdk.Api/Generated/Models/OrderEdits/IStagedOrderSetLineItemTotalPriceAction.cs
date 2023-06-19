using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemTotalPriceAction))]
    public partial interface IStagedOrderSetLineItemTotalPriceAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

    }
}
