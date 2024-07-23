using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeShipmentStateAction))]
    public partial interface IStagedOrderChangeShipmentStateAction : IStagedOrderUpdateAction
    {
        IShipmentState ShipmentState { get; set; }

    }
}
