using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.DeliveryRemovedMessagePayload))]
    public partial interface IDeliveryRemovedMessagePayload : IOrderMessagePayload
    {
        IDelivery Delivery { get; set; }
    }
}
