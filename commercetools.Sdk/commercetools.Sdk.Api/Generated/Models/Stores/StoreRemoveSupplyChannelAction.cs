using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreRemoveSupplyChannelAction : IStoreRemoveSupplyChannelAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public StoreRemoveSupplyChannelAction()
        {
            this.Action = "removeSupplyChannel";
        }
    }
}
