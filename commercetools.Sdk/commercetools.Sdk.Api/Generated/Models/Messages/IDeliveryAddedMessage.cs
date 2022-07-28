using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessage))]
    public partial interface IDeliveryAddedMessage : IOrderMessage
    {
        IDelivery Delivery { get; set; }

    }
}
