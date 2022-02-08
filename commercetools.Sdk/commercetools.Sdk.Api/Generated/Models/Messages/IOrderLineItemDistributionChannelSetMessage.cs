using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderLineItemDistributionChannelSetMessage))]
    public partial interface IOrderLineItemDistributionChannelSetMessage : IOrderMessage
    {
        string LineItemId { get; set; }

        IChannelReference DistributionChannel { get; set; }
    }
}
