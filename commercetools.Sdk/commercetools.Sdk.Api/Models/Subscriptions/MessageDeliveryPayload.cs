using commercetools.Api.Models.Messages;

namespace commercetools.Api.Models.Subscriptions
{
    public partial class MessageDeliveryPayload : IMessageDelivery
    {
        public IMessage Message { get; set; }
    }
}