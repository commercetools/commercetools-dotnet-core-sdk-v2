using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDeliveryAction))]
    public partial interface IStagedOrderRemoveDeliveryAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set; }

        string DeliveryKey { get; set; }

    }
}
