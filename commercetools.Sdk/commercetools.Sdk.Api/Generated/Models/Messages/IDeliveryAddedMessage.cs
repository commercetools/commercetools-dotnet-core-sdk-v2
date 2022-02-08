using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.DeliveryAddedMessage))]
    public partial interface IDeliveryAddedMessage : IOrderMessage
    {
        IDelivery Delivery { get; set; }
    }
}
