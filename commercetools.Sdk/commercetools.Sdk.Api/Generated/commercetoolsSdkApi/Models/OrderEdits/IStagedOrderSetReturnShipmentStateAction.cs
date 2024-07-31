using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnShipmentStateAction))]
    public partial interface IStagedOrderSetReturnShipmentStateAction : IStagedOrderUpdateAction
    {
        string ReturnItemId { get; set; }

        string ReturnItemKey { get; set; }

        IReturnShipmentState ShipmentState { get; set; }

    }
}
