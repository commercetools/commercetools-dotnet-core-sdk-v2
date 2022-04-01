using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDeliveryAction))]
    public partial interface IStagedOrderRemoveDeliveryAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set; }
    }
}
