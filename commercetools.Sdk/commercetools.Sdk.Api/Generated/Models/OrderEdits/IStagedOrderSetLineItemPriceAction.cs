using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetLineItemPriceAction))]
    public partial interface IStagedOrderSetLineItemPriceAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        IMoney ExternalPrice { get; set; }

    }
}
