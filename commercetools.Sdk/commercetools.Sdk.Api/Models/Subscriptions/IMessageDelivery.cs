using commercetools.Sdk.Api.Models.Messages;

namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public partial interface IMessageDelivery : IDeliveryPayload
    {
        IMessage Message { get; set; }
    }
}