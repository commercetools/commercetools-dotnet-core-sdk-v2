using commercetools.Api.Models.Messages;

namespace commercetools.Api.Models.Subscriptions
{
    public partial interface IMessageDelivery : IDeliveryPayload
    {
        IMessage Message { get; set; }
    }
}