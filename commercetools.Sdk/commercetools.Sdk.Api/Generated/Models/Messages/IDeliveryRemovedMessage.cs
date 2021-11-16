using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.DeliveryRemovedMessage))]
    public partial interface IDeliveryRemovedMessage : IMessage
    {
        IDelivery Delivery { get; set; }
    }
}
