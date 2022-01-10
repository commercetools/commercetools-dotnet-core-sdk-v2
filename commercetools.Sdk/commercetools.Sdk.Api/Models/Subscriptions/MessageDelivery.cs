using commercetools.Api.Models.Messages;

namespace commercetools.Api.Models.Subscriptions
{
    public partial class MessageDelivery : IMessageDelivery
    {
        public IMessage Message { get; set; }
    }
}