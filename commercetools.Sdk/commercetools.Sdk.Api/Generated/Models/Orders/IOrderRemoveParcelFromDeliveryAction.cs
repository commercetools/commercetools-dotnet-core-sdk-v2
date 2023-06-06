using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderRemoveParcelFromDeliveryAction))]
    public partial interface IOrderRemoveParcelFromDeliveryAction : IOrderUpdateAction
    {
        string ParcelId { get; set; }

        string ParcelKey { get; set; }

    }
}
