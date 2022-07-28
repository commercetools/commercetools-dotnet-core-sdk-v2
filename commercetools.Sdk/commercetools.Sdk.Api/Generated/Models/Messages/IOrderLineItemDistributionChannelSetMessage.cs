using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessage))]
    public partial interface IOrderLineItemDistributionChannelSetMessage : IOrderMessage
    {
        string LineItemId { get; set; }

        IChannelReference DistributionChannel { get; set; }

    }
}
