using commercetools.Api.Models.Messages;

namespace commercetools.Api.Models.Subscriptions
{
    public partial interface IMessageDelivery : ISubscriptionDelivery
    {
        IMessage Message { get; set; }
    }
}