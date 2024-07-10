using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetLineItemSupplyChannelAction : ICartSetLineItemSupplyChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public CartSetLineItemSupplyChannelAction()
        {
            this.Action = "setLineItemSupplyChannel";
        }
    }
}
