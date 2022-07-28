using commercetools.Sdk.Api.Models.Messages;

namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public partial interface IMessageDelivery : IDeliveryPayload
    {
        new IMessage Message { get; set; }
    }
}