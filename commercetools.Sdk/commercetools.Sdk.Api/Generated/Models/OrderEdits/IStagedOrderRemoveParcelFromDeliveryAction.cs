using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveParcelFromDeliveryAction))]
    public partial interface IStagedOrderRemoveParcelFromDeliveryAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }
    }
}
