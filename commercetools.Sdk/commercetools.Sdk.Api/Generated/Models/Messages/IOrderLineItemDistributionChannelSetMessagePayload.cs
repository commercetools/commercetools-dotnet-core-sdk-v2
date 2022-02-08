using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderLineItemDistributionChannelSetMessagePayload))]
    public partial interface IOrderLineItemDistributionChannelSetMessagePayload : IOrderMessagePayload
    {
        string LineItemId { get; set; }

        IChannelReference DistributionChannel { get; set; }
    }
}
