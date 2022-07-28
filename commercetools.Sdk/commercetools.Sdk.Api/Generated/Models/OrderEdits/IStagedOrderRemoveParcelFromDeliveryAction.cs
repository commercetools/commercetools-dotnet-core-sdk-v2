using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveParcelFromDeliveryAction))]
    public partial interface IStagedOrderRemoveParcelFromDeliveryAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

    }
}
