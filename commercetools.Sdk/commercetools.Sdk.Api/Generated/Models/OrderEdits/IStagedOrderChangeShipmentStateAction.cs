using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeShipmentStateAction))]
    public partial interface IStagedOrderChangeShipmentStateAction : IStagedOrderUpdateAction
    {
        IShipmentState ShipmentState { get; set; }

    }
}
