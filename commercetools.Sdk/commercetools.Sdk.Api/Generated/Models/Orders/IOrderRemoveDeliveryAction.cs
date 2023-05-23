using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderRemoveDeliveryAction))]
    public partial interface IOrderRemoveDeliveryAction : IOrderUpdateAction
    {
        string DeliveryId { get; set; }

        string DeliveryKey { get; set; }

    }
}
