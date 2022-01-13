using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveDeliveryAction))]
    public partial interface IStagedOrderRemoveDeliveryAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set; }
    }
}
