using commercetools.Api.Models.Channels;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetLineItemDistributionChannelAction : IMyCartSetLineItemDistributionChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public MyCartSetLineItemDistributionChannelAction()
        {
            this.Action = "setLineItemDistributionChannel";
        }
    }
}
