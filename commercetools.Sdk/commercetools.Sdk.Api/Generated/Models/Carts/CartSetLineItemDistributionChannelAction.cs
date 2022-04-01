using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartSetLineItemDistributionChannelAction : ICartSetLineItemDistributionChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IChannelResourceIdentifier DistributionChannel { get; set; }
        public CartSetLineItemDistributionChannelAction()
        {
            this.Action = "setLineItemDistributionChannel";
        }
    }
}
