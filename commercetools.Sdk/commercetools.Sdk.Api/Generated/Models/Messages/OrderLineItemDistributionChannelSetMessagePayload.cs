using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderLineItemDistributionChannelSetMessagePayload : IOrderLineItemDistributionChannelSetMessagePayload
    {
        public string Type { get; set; }

        public string LineItemId { get; set; }

        public IChannelReference DistributionChannel { get; set; }
        public OrderLineItemDistributionChannelSetMessagePayload()
        {
            this.Type = "OrderLineItemDistributionChannelSet";
        }
    }
}
