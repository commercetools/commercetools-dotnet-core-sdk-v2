using commercetools.Api.Models.Channels;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetLineItemSupplyChannelAction : ICartSetLineItemSupplyChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public CartSetLineItemSupplyChannelAction()
        {
            this.Action = "setLineItemSupplyChannel";
        }
    }
}
