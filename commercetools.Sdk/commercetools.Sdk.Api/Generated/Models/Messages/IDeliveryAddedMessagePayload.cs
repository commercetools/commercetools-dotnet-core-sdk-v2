using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.DeliveryAddedMessagePayload))]
    public partial interface IDeliveryAddedMessagePayload : IOrderMessagePayload
    {
        IDelivery Delivery { get; set; }
    }
}
