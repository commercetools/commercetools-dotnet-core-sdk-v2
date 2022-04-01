using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyCartSetLineItemSupplyChannelAction : IMyCartSetLineItemSupplyChannelAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public MyCartSetLineItemSupplyChannelAction()
        {
            this.Action = "setLineItemSupplyChannel";
        }
    }
}
