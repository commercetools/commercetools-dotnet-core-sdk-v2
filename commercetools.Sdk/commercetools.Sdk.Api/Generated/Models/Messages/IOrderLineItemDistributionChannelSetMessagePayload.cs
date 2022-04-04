using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemDistributionChannelSetMessagePayload))]
    public partial interface IOrderLineItemDistributionChannelSetMessagePayload : IOrderMessagePayload
    {
        string LineItemId { get; set; }

        IChannelReference DistributionChannel { get; set; }
    }
}
