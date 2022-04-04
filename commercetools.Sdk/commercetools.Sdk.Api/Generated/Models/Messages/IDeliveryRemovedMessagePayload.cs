using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessagePayload))]
    public partial interface IDeliveryRemovedMessagePayload : IOrderMessagePayload
    {
        IDelivery Delivery { get; set; }
    }
}
