using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetLineItemDistributionChannelAction : IStagedOrderSetLineItemDistributionChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public StagedOrderSetLineItemDistributionChannelAction()
        {
            this.Action = "setLineItemDistributionChannel";
        }
    }
}
