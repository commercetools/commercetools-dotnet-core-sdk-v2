using commercetools.Sdk.Api.Models.Messages;

namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public partial class MessageDeliveryPayload : IMessageDelivery
    {
        public IMessage Message { get; set; }
    }
}