using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Stores
{
    public partial class StoreAddSupplyChannelAction : IStoreAddSupplyChannelAction
    {
        public string Action { get; set; }

        public IChannelResourceIdentifier SupplyChannel { get; set; }
        public StoreAddSupplyChannelAction()
        {
            this.Action = "addSupplyChannel";
        }
    }
}
