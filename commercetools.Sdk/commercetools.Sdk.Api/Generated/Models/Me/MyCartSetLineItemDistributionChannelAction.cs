using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetLineItemDistributionChannelAction : IMyCartSetLineItemDistributionChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public MyCartSetLineItemDistributionChannelAction()
        {
            this.Action = "setLineItemDistributionChannel";
        }
    }
}
