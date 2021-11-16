using commercetools.Api.Models.Channels;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetLineItemDistributionChannelAction : ICartSetLineItemDistributionChannelAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IChannelResourceIdentifier DistributionChannel { get; set;}
        public CartSetLineItemDistributionChannelAction()
        { 
           this.Action = "setLineItemDistributionChannel";
        }
    }
}
